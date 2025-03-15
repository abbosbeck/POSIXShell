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
            switch (command)
            {
                case "color 0": Console.ForegroundColor = ConsoleColor.Black; break;
                case "color 1": Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case "color 2": Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case "color 3": Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                case "color 4": Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case "color 5": Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case "color 6": Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case "color 7": Console.ForegroundColor = ConsoleColor.Gray; break;
                case "color 8": Console.ForegroundColor = ConsoleColor.DarkGray; break;
                case "color 9": Console.ForegroundColor = ConsoleColor.Blue; break;
                case "color a": Console.ForegroundColor = ConsoleColor.Green; break;
                case "color b": Console.ForegroundColor = ConsoleColor.Cyan; break;
                case "color c": Console.ForegroundColor = ConsoleColor.Red; break;
                case "color d": Console.ForegroundColor = ConsoleColor.Magenta; break;
                case "color e": Console.ForegroundColor = ConsoleColor.Yellow; break;
                case "color f": Console.ForegroundColor = ConsoleColor.White; break;

                case "reset":
                    Console.ResetColor();
                    Console.WriteLine("Colors reset to default.");
                    return;

                default:
                    Console.WriteLine("Invalid color command.");
                    return;
            }
        }
    }
}
