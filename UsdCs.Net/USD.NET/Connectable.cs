using System;
using pxr;

namespace USD.NET
{
	public interface Connectable
	{
		object GetValue();

		Type GetValueType();

		string GetConnectedPath();

		void SetConnectedPath(string path);

		void SetValue(object value);
	}
	public class Connectable<T> : Connectable
	{
		public T defaultValue;

		public string connectedPath { get; private set; }

		public Connectable()
		{
		}

		public Connectable(T defaultValue)
		{
			this.defaultValue = defaultValue;
		}

		public bool IsConnected()
		{
			return !string.IsNullOrEmpty(connectedPath);
		}

		public Type GetValueType()
		{
			return typeof(T);
		}

		public object GetValue()
		{
			return defaultValue;
		}

		public void SetValue(object value)
		{
			defaultValue = (T)value;
		}

		public string GetConnectedPath()
		{
			return connectedPath;
		}

		public void SetConnectedPath(string path)
		{
			connectedPath = new SdfPath(path).ToString();
		}

		public void SetConnectedPath(string path, string attribute)
		{
			connectedPath = new SdfPath(path).AppendProperty(new TfToken(attribute)).ToString();
		}
	}
}
