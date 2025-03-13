namespace POSIXShell.Factories.Commands
{
    public class ExitCommand : IRun
    {
        public ExitCommand()
        {
            Run("");
        }
        public void Run(string command)
        {
            Environment.Exit(0);
        }
    }
}
