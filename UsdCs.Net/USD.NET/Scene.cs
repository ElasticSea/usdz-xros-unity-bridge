using System;
using System.Collections.Generic;
using System.Reflection;
using pxr;

namespace USD.NET
{
	public class Scene
	{
		public enum WriteModes
		{
			Define,
			Over
		}

		public enum InterpolationMode
		{
			Held,
			Linear
		}

		public enum UpAxes
		{
			Y,
			Z
		}

		private double? m_time;

		private Dictionary<string, SdfPath> m_pathMap = new Dictionary<string, SdfPath>();

		private object m_stageLock = new object();

		private UsdIo m_usdIo;

		private UsdStage m_stage;

		private static readonly TfToken kUpAxisToken = new TfToken("upAxis");

		private static readonly TfToken kYUpToken = new TfToken("Y");

		private static readonly TfToken kMetersPerUnitToken = new TfToken("metersPerUnit");

		public UsdStage Stage => m_stage;

		public AccessMask AccessMask { get; set; }

		public bool IsPopulatingAccessMask { get; set; }

		public string FilePath => m_stage.GetEditTarget().GetLayer().identifier;

		public WriteModes WriteMode { get; set; }

		public double? Time
		{
			get
			{
				return m_time;
			}
			set
			{
				m_time = value;
				TimeCode = (m_time.HasValue ? new UsdTimeCode(m_time.Value) : UsdTimeCode.Default());
			}
		}

		public double StartTime
		{
			get
			{
				return Stage.GetEditTarget().GetLayer().GetStartTimeCode();
			}
			set
			{
				lock (m_stageLock)
				{
					Stage.GetEditTarget().GetLayer().SetStartTimeCode(value);
				}
			}
		}

		public double EndTime
		{
			get
			{
				return Stage.GetEditTarget().GetLayer().GetEndTimeCode();
			}
			set
			{
				lock (m_stageLock)
				{
					Stage.GetEditTarget().GetLayer().SetEndTimeCode(value);
				}
			}
		}

		public double FrameRate
		{
			get
			{
				return Stage.GetFramesPerSecond();
			}
			set
			{
				if (value <= 0.0)
				{
					throw new ApplicationException("Invalid frame rate, frame rate must be > 0");
				}
				lock (m_stageLock)
				{
					Stage.SetTimeCodesPerSecond(value);
					Stage.SetFramesPerSecond(value);
				}
			}
		}

		public UpAxes UpAxis
		{
			get
			{
				VtValue value = new VtValue();
				string value2 = null;
				if (Stage.GetMetadata(kUpAxisToken, value))
				{
					value2 = Vt.VtValueToTfToken(value).ToString();
				}
				if (!string.IsNullOrEmpty(value2))
				{
					return (UpAxes)Enum.Parse(typeof(UpAxes), value2);
				}
				return UpAxes.Z;
			}
			set
			{
				VtValue value2 = new TfToken(value.ToString());
				Stage.SetMetadata(kUpAxisToken, value2);
			}
		}

		public double MetersPerUnit
		{
			get
			{
				if (Stage == null)
				{
					throw new InvalidOperationException("Stage uninitialized");
				}
				VtValue value = new VtValue();
				if (Stage.GetMetadata(kMetersPerUnitToken, value))
				{
					return Vt.VtValueTodouble(value);
				}
				return 0.01;
			}
			set
			{
				if (value <= 0.0)
				{
					throw new ArgumentOutOfRangeException("MetersPerUnit", "Invalid metersPerUnit, meters per unit must be > 0");
				}
				Stage.SetMetadata(kMetersPerUnitToken, new VtValue(value));
			}
		}

		public SdfPath[] AllPaths => VectorToArray(Stage.GetAllPaths());

		[Obsolete("Use Find<MeshSample>() instead. This API will be removed in a future release.")]
		public SdfPath[] AllMeshes => VectorToArray(Stage.GetAllPathsByType("Mesh", SdfPath.AbsoluteRootPath()));

		[Obsolete("Use Find<XformableSample>() instead. This API will be removed in a future release.")]
		public SdfPath[] AllXforms => VectorToArray(Stage.GetAllPathsByType("Xform", SdfPath.AbsoluteRootPath()));

		private UsdTimeCode TimeCode { get; set; }

		public static Scene Create(string filePath)
		{
			UsdStage usdStage = UsdStage.CreateNew(filePath);
			if (usdStage == null)
			{
				throw new ApplicationException("Failed to create: " + filePath);
			}
			Scene scene = new Scene(usdStage);
			scene.UpAxis = UpAxes.Y;
			scene.MetersPerUnit = 1.0;
			return scene;
		}

		public static Scene Create()
		{
			Scene scene = new Scene(UsdStage.CreateInMemory());
			scene.UpAxis = UpAxes.Y;
			scene.MetersPerUnit = 1.0;
			return scene;
		}

		public static Scene Open(string filePath)
		{
			UsdStage usdStage = UsdStage.Open(filePath);
			if (usdStage == null)
			{
				throw new ApplicationException("Failed to open: " + filePath);
			}
			return new Scene(usdStage);
		}

		public static Scene Open(UsdStage stage)
		{
			if (stage == null)
			{
				throw new NullReferenceException("Null stage");
			}
			return new Scene(stage);
		}

		public UsdPrim GetPrimAtPath(string primPath)
		{
			UsdPrim primAtPath = Stage.GetPrimAtPath(new SdfPath(primPath));
			if (primAtPath == null || !primAtPath.IsValid())
			{
				return null;
			}
			return primAtPath;
		}

		public SdfPath GetSdfPath(string path)
		{
			if (!m_pathMap.TryGetValue(path, out var value))
			{
				value = new SdfPath(path);
				m_pathMap[path] = value;
			}
			return value;
		}

		public UsdAttribute GetAttributeAtPath(string attrPath)
		{
			SdfPath path = new SdfPath(attrPath);
			UsdAttribute attributeAtPath = Stage.GetAttributeAtPath(path);
			if (attributeAtPath == null || !attributeAtPath.IsValid())
			{
				return null;
			}
			return attributeAtPath;
		}

		public UsdRelationship GetRelationshipAtPath(string relPath)
		{
			SdfPath path = new SdfPath(relPath);
			UsdRelationship relationshipAtPath = Stage.GetRelationshipAtPath(path);
			if (relationshipAtPath == null || !relationshipAtPath.IsValid())
			{
				return null;
			}
			return relationshipAtPath;
		}

		public SdfPath[] Find<T>() where T : SampleBase, new()
		{
			return Find<T>(SdfPath.AbsoluteRootPath());
		}

		public SdfPath[] Find<T>(string rootPath) where T : SampleBase, new()
		{
			return Find<T>(new SdfPath(rootPath));
		}

		public SdfPath[] Find<T>(SdfPath rootPath) where T : SampleBase, new()
		{
			object[] customAttributes = typeof(T).GetCustomAttributes(typeof(UsdSchemaAttribute), inherit: true);
			if (customAttributes.Length == 0)
			{
				throw new ApplicationException("Invalid type T, does not have UsdSchema attribute");
			}
			string name = ((UsdSchemaAttribute)customAttributes[0]).Name;
			return VectorToArray(Stage.GetAllPathsByType(name, rootPath));
		}

		public SdfPath[] Find(string rootPath, string usdSchemaTypeName)
		{
			return VectorToArray(Stage.GetAllPathsByType(usdSchemaTypeName, new SdfPath(rootPath)));
		}

		public SampleCollection<T> ReadAll<T>() where T : SampleBase, new()
		{
			return ReadAll<T>(SdfPath.AbsoluteRootPath());
		}

		public SampleCollection<T> ReadAll<T>(string rootPath) where T : SampleBase, new()
		{
			return ReadAll<T>(new SdfPath(rootPath));
		}

		public SampleCollection<T> ReadAll<T>(SdfPath rootPath) where T : SampleBase, new()
		{
			object[] customAttributes = typeof(T).GetCustomAttributes(typeof(UsdSchemaAttribute), inherit: true);
			if (customAttributes.Length == 0)
			{
				throw new ApplicationException("Invalid type T, does not have UsdSchema attribute");
			}
			string name = ((UsdSchemaAttribute)customAttributes[0]).Name;
			SdfPathVector allPathsByType = Stage.GetAllPathsByType(name, rootPath);
			return new SampleCollection<T>(this, allPathsByType);
		}

		public SampleCollection<T> ReadAll<T>(SdfPath[] paths) where T : SampleBase, new()
		{
			SdfPathVector sdfPathVector = new SdfPathVector();
			foreach (SdfPath x in paths)
			{
				sdfPathVector.Add(x);
			}
			return new SampleCollection<T>(this, sdfPathVector);
		}

		public void Close()
		{
			if (m_stage != null)
			{
				m_stage.Dispose();
				m_stage = null;
			}
		}

		public void SetInterpolation(InterpolationMode mode)
		{
			switch (mode)
			{
			case InterpolationMode.Held:
				Stage.SetInterpolationType(UsdInterpolationType.UsdInterpolationTypeHeld);
				break;
			case InterpolationMode.Linear:
				Stage.SetInterpolationType(UsdInterpolationType.UsdInterpolationTypeLinear);
				break;
			default:
				throw new ArgumentException($"Unknown interpolation mode: {mode}");
			}
		}

		public Dictionary<string, double[]> ComputeKeyFrames(string rootPath, string attribute)
		{
			Dictionary<string, double[]> dictionary = new Dictionary<string, double[]>();
			UsdPrim usdPrim = GetUsdPrim(GetSdfPath(rootPath));
			if (!usdPrim)
			{
				throw new ArgumentException("rootPath does not exist");
			}
			SdfPath sdfPath = GetSdfPath(rootPath);
			TfToken attrName = new TfToken(attribute);
			foreach (UsdPrim allPrim in Stage.GetAllPrims())
			{
				if (!(allPrim.GetPath() == SdfPath.AbsoluteRootPath()) && allPrim.GetPath().HasPrefix(sdfPath))
				{
					StdDoubleVector timeSamples = allPrim.GetAttribute(attrName).GetTimeSamples();
					if (timeSamples.Count != 0)
					{
						double[] array = new double[timeSamples.Count];
						timeSamples.CopyTo(array);
						dictionary.Add(allPrim.GetPath(), array);
					}
				}
			}
			return dictionary;
		}

		public void AddSubLayer(Scene over)
		{
			SdfLayerHandle rootLayer = Stage.GetRootLayer();
			SdfLayerHandle rootLayer2 = over.Stage.GetRootLayer();
			rootLayer.GetSubLayerPaths().push_back(rootLayer2.identifier);
		}

		public void SetEditTarget(Scene other)
		{
			SdfLayerHandle rootLayer = other.Stage.GetRootLayer();
			UsdEditTarget editTargetForLocalLayer = Stage.GetEditTargetForLocalLayer(rootLayer);
			Stage.SetEditTarget(editTargetForLocalLayer);
		}

		public void Save()
		{
			m_stage.Save();
		}

		public void SaveAs(string filePath)
		{
			m_stage.GetEditTarget().GetLayer().Export(filePath);
		}

		public void FlattenAs(string filePath)
		{
			m_stage.Flatten(addSourceFileComment: false).Export(filePath);
		}

		public void Read<T>(string path, T sample) where T : SampleBase
		{
			ReadInternal(GetSdfPath(path), sample, TimeCode);
		}

		public void Read<T>(SdfPath path, T sample) where T : SampleBase
		{
			ReadInternal(path, sample, TimeCode);
		}

		public void Read<T>(string path, FieldInfo fieldInfo, ref T memberValue)
		{
			Read(GetSdfPath(path), fieldInfo, ref memberValue);
		}

		public void Read<T>(SdfPath path, FieldInfo fieldInfo, ref T memberValue)
		{
			UsdPrim usdPrim = GetUsdPrim(path);
			object fieldValue = memberValue;
			bool? mayVary = null;
			m_usdIo.Deserialize(ref fieldValue, usdPrim, TimeCode, fieldInfo, null, ref mayVary);
			memberValue = (T)fieldValue;
		}

		public void Read<T>(string path, PropertyInfo fieldInfo, ref T memberValue)
		{
			Read(GetSdfPath(path), fieldInfo, ref memberValue);
		}

		public void Read<T>(SdfPath path, PropertyInfo propInfo, ref T memberValue)
		{
			UsdPrim usdPrim = GetUsdPrim(path);
			object propValue = memberValue;
			bool? mayVary = null;
			m_usdIo.Deserialize(ref propValue, usdPrim, TimeCode, propInfo, null, ref mayVary);
			memberValue = (T)propValue;
		}

		private void ReadInternal<T>(SdfPath path, T sample, UsdTimeCode timeCode) where T : SampleBase
		{
			UsdPrim usdPrim = GetUsdPrim(path);
			if (!usdPrim)
			{
				return;
			}
			AccessMask accessMask = AccessMask;
			DeserializationContext value = null;
			bool? mayVary = false;
			if (accessMask != null)
			{
				bool isPopulatingAccessMask = IsPopulatingAccessMask;
				lock (m_stageLock)
				{
					bool flag = accessMask.Included.TryGetValue(path, out value);
					if (!flag && isPopulatingAccessMask)
					{
						value = new DeserializationContext();
						accessMask.Included.Add(path, value);
					}
				}
				if (!isPopulatingAccessMask)
				{
					if (value?.dynamicMembers == null)
					{
						return;
					}
					mayVary = null;
				}
			}
			m_usdIo.Deserialize(sample, usdPrim, timeCode, value?.dynamicMembers, ref mayVary);
			lock (m_stageLock)
			{
				if (accessMask != null && mayVary.HasValue && !mayVary.Value && accessMask.Included.ContainsKey(path))
				{
					accessMask.Included.Remove(path);
				}
			}
		}

		public void Write<T>(string path, T sample) where T : SampleBase
		{
			Write(GetSdfPath(path), sample);
		}

		public void Write<T>(SdfPath path, T sample) where T : SampleBase
		{
			WriteInternal(path, sample, TimeCode);
		}

		private void WriteInternal<T>(SdfPath path, T sample, UsdTimeCode timeCode) where T : SampleBase
		{
			UsdPrim usdPrim;
			lock (m_stageLock)
			{
				if (WriteMode == WriteModes.Define)
				{
					string schema = Reflect.GetSchema(typeof(T));
					usdPrim = m_stage.GetPrimAtPath(path);
					if (usdPrim == null || !usdPrim.IsValid())
					{
						usdPrim = m_stage.DefinePrim(path, new TfToken(schema));
					}
					else if (!string.IsNullOrEmpty(schema) && (string.IsNullOrEmpty(usdPrim.GetTypeName().GetText()) || schema != "Xform"))
					{
						usdPrim.SetTypeName(new TfToken(schema));
					}
				}
				else
				{
					usdPrim = m_stage.OverridePrim(path);
				}
				if (usdPrim == null || !usdPrim.IsValid())
				{
					throw new Exception("Failed to " + ((WriteMode == WriteModes.Define) ? "define" : "override") + " prim: " + path);
				}
			}
			m_usdIo.Serialize(sample, usdPrim, timeCode);
		}

		public override string ToString()
		{
			m_stage.ExportToString(out var result, addSourceFileComment: false);
			return result;
		}

		private SdfPath[] VectorToArray(SdfPathVector vec)
		{
			SdfPath[] array = new SdfPath[vec.Count];
			vec.CopyTo(array);
			return array;
		}

		private SdfPath GetSdfPath(SdfPath path)
		{
			throw new ApplicationException("TODO: don't allow implicit conversion path -> string");
		}

		private UsdPrim GetUsdPrim(string path)
		{
			return GetUsdPrim(GetSdfPath(path));
		}

		private UsdPrim GetUsdPrim(SdfPath path)
		{
			lock (m_stageLock)
			{
				return Stage.GetPrimAtPath(path);
			}
		}

		private Scene(UsdStage stage)
		{
			if (stage == null)
			{
				throw new NullReferenceException("Scene was constructed with a null UsdStage");
			}
			m_stage = stage;
			m_usdIo = new UsdIo(m_stageLock);
			Time = null;
		}
	}
}
