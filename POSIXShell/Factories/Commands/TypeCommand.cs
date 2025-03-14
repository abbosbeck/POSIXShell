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
                var pathsStr = Environment.GetEnvironmentVariable("PATH");
                var pathsArr = pathsStr.Split(":");
                bool isFound = false;
                foreach (var path in pathsArr)
                {
                    var joinedPath = Path.Join(path, command);
                    if (File.Exists(joinedPath))
                    {
                        isFound = true;
                        Console.WriteLine($"{command} is {joinedPath}");
                        break;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine($"{command}: not found");
                }
            }
        }
    }
}
