using POSIXShell.Factories.Commands;
using POSIXShell.Factories.Commands.ScriptingSupport;

namespace POSIXShell.Factories
{
    public class CommandFactory
    {
        public static IRun GetCommand(string commandName)
        {
            ReadOnlySpan<char> span = commandName.AsSpan();
            int spaceIndex = span.IndexOf(' ');
            string commandType = spaceIndex == -1 ? commandName : new string(span.Slice(0, spaceIndex));
                
            commandName = commandName.Contains(" ") ? commandName.Substring(5) : commandName;

            return commandType switch
            {
                "type" => new TypeCommand(commandName),
                "exit" => new ExitCommand(),
                "echo" => new EchoCommand(commandName),
                "color" => new ColorCommand(commandName),
                "cls" => new CleanConsoleCommand(commandName),

                "code" => new RoslynScripting(commandName),

                _ => new NoCommand(commandName),
            };
        }
    }
}
