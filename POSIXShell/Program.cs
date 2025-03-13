while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine();

    if(command == "exit")
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine($"{command}: command not found");
    }

}

