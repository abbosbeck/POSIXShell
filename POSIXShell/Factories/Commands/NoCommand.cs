namespace POSIXShell.Factories.Commands
{
    public class NoCommand : IRun
    {
        public NoCommand(string command)
        {
            Run(command);
        }

        public void Run(string command)
        {
            Console.WriteLine($"{command}: not found");
        }
    }
}
