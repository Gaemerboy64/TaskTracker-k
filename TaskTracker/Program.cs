var exitConditionMet = true;
do {
        Console.WriteLine("Welcome to TaskTracker!");
        Console.WriteLine("1. List Tasks");
        Console.WriteLine("2. About");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");

        int.TryParse(Console.ReadLine(), null, out int input);

        if (input == 2)
        {
            Console.WriteLine("Kyle Fish");
            Console.WriteLine("GaemerBoy64");
            Console.WriteLine(DateTime.IsLeapYear(1998));
            Console.WriteLine(DateTime.Now);
        }

        if (input == 3)
        exitConditionMet = false;
    } while (exitConditionMet == true);
