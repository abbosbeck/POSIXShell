namespace POSIXShell.Factories.Commands
{
    public class EchoCommand : IRun
    {
        public EchoCommand(string command)
        {
            Run(command);
        }
        public void Run(string command)
        {
            Console.WriteLine(command);
        }
    }
}
