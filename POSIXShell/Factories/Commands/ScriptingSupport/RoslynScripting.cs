using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace POSIXShell.Factories.Commands.ScriptingSupport
{
    public class RoslynScripting : IRun
    {
        public RoslynScripting(string code)
        {
            Run(code);
        }
        public async void Run(string command)
        {
           var a =  await RunScript(command);

           Console.WriteLine(a);
        }

        public static async Task<object> RunScript(string code)
        {
            return await CSharpScript.EvaluateAsync(code, ScriptOptions.Default);
        }
    }
}
