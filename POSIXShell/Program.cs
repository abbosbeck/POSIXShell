while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine();

    if(command == "exit")
    {
        Environment.Exit(0);
    }else if (command.StartsWith("echo"))
    {
        command = command.Substring(5);
        Console.WriteLine(command);
    }
    else
    {
        Console.WriteLine($"{command}: command not found");
    }

}

