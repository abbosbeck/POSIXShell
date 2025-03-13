namespace POSIXShell.Factories.Commands
{
    public class TypeCommand : IRun
    {
        public TypeCommand(string a)
        {
            Run(a);
        }
        public void Run(string command)
        {
            command = command.Substring(5);
            if (command == "exit" || command == "echo" || command == "type")
            {
                Console.WriteLine($"{command} is a shell builtin");
            }
            else
            {
                Console.WriteLine($"{command}: not found");
            }
        }
    }
}
