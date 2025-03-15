using POSIXShell.Factories;

while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine();

    CommandFactory.GetCommand(command);
}

