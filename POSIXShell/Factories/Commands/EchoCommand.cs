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
            command = command.Substring(5);
            Console.WriteLine(command);
        }
    }
}
