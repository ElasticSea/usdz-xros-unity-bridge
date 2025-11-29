using EscapeUnusedMethods;

var managedDir = "D:\\ElasticSea\\usdz-xros-unity-bridge\\UsdCs.Net";
var exportFile = "D:\\ElasticSea\\usdz-xros-unity-bridge\\UsdCsWrapper\\src\\stubs.cpp";
var implementedFile = "implemented.txt";

var managedFiles = Directory.GetFiles(managedDir, "*.cs", SearchOption.AllDirectories);
var managedSignatures = MethodSignature.GetSignatures(managedFiles);
var implementedMethods = File.ReadLines(implementedFile).Select(l => l.Trim()).ToHashSet();
managedSignatures = managedSignatures.Where(m => !implementedMethods.Contains(m.Signature)).ToArray();
var output = Export.ExportMethods(managedSignatures);
File.WriteAllText(exportFile, output);