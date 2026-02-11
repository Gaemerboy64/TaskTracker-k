using System.Security.AccessControl;
using Microsoft.JSInterop.Infrastructure;
using TaskTracker.TaskDomain;

var shouldContinue = true;
do
{
    Console.WriteLine("Welcome to TaskTracker!");
    Console.WriteLine("1. List Tasks");
    Console.WriteLine("2. About");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");
 
    int.TryParse(Console.ReadLine(), null, out int input);
 
 
    switch (input)
    {
        case 1:
            // list the tasks
            //TODO: add a project reference by turning the Domain into a Class library
            TaskItem task0ne = new();
            task0ne.Id = 1;
            task0ne.Title = "Work on Project Modpack";
            TaskItem tasktwo = new();
            tasktwo.Id = 2;
            tasktwo.Title = "Random text here";
            TaskItem taskthree = new();
            taskthree.Id = 3;
            taskthree.Title = "More random text";


            List<TaskItem> taskItems = [];
            taskItems.Add(task0ne);
            taskItems.Add(tasktwo);
            taskItems.Add(taskthree);

            Console.WriteLine(taskItems);

            foreach(var item in taskItems)
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }

            break;
        case 2:
    //dotnet restore
    //dotnet build
            break;
        case 3:
            shouldContinue = false;
            break;
        default:
            shouldContinue = false;
            break;
    }
    // make it so that the pro
} while (shouldContinue);

void AboutMeInformation()
{
    Console.WriteLine("Kyle Fish");
    Console.WriteLine("Gaemerboy64");
    Console.WriteLine(DateTime.IsLeapYear(1998));
    Console.WriteLine(DateTime.Now);
    Console.WriteLine();
}
 