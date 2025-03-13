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
    }else if (command.StartsWith("type"))
    {
        command = command.Substring(5);
        if (command == "exit" || command == "echo")
        {
            Console.WriteLine($"{command} is a shell builtin");
        }
        else
        {
            Console.WriteLine($"{command}: not found");
        }
    }
    else
    {
        Console.WriteLine($"{command}: command not found");
    }

}

