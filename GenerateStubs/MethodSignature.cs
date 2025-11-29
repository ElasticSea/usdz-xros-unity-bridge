using System.Text.RegularExpressions;

namespace EscapeUnusedMethods;

public class MethodSignature
{
    public string Signature;
    public returns ReturnType;
    public Arg[] Args;

    public MethodSignature(string signature, string returnType, string methodName, string[] args)
    {
        if (!returns.TryParse(returnType, out returns @case))
        {
            throw new Exception();
        }
        Signature = !string.IsNullOrWhiteSpace(signature) ? signature : methodName;
        ReturnType = @case;
        Args = args.Select(a =>
        {
            string aTrim = a.Trim();
            int idx = aTrim.LastIndexOf(' ');

            string type = aTrim.Substring(0, idx);
            string name = aTrim.Substring(idx + 1);

            return new Arg(type, name);
        }).ToArray();
    }

    public static MethodSignature[] GetSignatures(IEnumerable<string> files)
    {
        var signatures = new List<MethodSignature>();
        var fs = files.ToArray();
        for (var index = 0; index < fs.Length; index++)
        {
            var file = fs[index];
            var fileTextLines = File.ReadAllLines(file);
            for (var i = 0; i < fileTextLines.Length; i++)
            {
                var line = fileTextLines[i];
                var isExtern = line.Contains("[DllImport(");
                if (isExtern)
                {
                    i++;
                    var methodLine = fileTextLines[i];
                    if (methodLine.Contains("MonoPInvokeCallback"))
                    {
                        i++;
                        methodLine = fileTextLines[i];
                    }

                    methodLine = Regex.Replace(methodLine, @"\[[^\]]*\]", "").Trim();
                    string sign = Match(line, @"EntryPoint\s*=\s*""([^""]+)""", true);
                    string returnType = Match(methodLine, @"extern\s+(\S+)\s+[A-Za-z0-9_]+\s*\(");
                    string methodName = Match(methodLine, @"extern\s+\S+\s+([A-Za-z0-9_]+)\s*\(");
                    string args = Match(methodLine, @"extern\s+\S+\s+[A-Za-z0-9_]+\s*\(([^)]*)\)");
                    var signature = new MethodSignature(sign, returnType, methodName, args is null or "" ? [] : args.Split(','));
                    signatures.Add(signature);
                }
            }
        }

        return signatures.ToArray();
    }

    static string Match(string line, string regex, bool canBeNull = false)
    {
        var m = Regex.Match(line, regex);
        if (m.Success)
        {
            return m.Groups[1].Value;
        }

        if (canBeNull)
        {
            return null;

        }
        else
        {
            throw new Exception(line + " " +regex);
        }
    }
}