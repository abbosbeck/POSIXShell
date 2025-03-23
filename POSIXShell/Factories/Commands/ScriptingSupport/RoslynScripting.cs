using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace POSIXShell.Factories.Commands.ScriptingSupport
{
    public class RoslynScripting
    {
        public static async Task<object> RunScript(string code)
        {
            return await CSharpScript.EvaluateAsync(code, ScriptOptions.Default);
        }
    }
}
