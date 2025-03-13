using POSIXShell.Factories.Commands;

namespace POSIXShell.Factories
{
    public class CommandFactory
    {
        public static IRun GetCommand(string commandName)
        {
            ReadOnlySpan<char> span = commandName.AsSpan();
            int spaceIndex = span.IndexOf(' ');
            string commandType = spaceIndex == -1 ? commandName : new string(span.Slice(0, spaceIndex));

            return commandType switch
            {
                "type" => new TypeCommand(commandName),
                "exit" => new ExitCommand(),
                "echo" =>new EchoCommand(commandName),
                _ => new NoCommand(commandName),
            };
        }
    }
}
