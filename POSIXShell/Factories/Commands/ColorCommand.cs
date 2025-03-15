namespace POSIXShell.Factories.Commands
{
    public class ColorCommand : IRun
    {
        public ColorCommand(string command)
        {
            Run(command);
        }
        public void Run(string command)
        {
            if (command == "color a")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("cheking text");
            }
            else if (command == "color r")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}
