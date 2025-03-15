namespace POSIXShell.Factories.Commands
{
    public class CleanConsoleCommand : IRun
    {
        public CleanConsoleCommand(string commandName)
        {
            Run(commandName);
        }
        public void Run(string command)
        {
            throw new NotImplementedException();
        }
    }
}
