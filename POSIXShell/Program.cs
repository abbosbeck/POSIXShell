using POSIXShell.Factories;
using POSIXShell.Factories.Commands;

while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine();

    CommandFactory.GetCommand(command);
}

