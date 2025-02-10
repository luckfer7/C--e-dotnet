
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

List<string> tasksList = new List<string>();

while (true)
{
    Console.WriteLine("\n==== Your tasks list ====\n");
    Console.WriteLine("Choose a number: ");
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. Show all tasks");
    Console.WriteLine("3. Delete task");
    Console.WriteLine("4. exit");

    string chosenNumber = Console.ReadLine();

    switch(chosenNumber)
    {
        case "1":
            Console.WriteLine("Type the task would like to add: ");
            string task = Console.ReadLine();
            tasksList.Add(task);
            Console.WriteLine($"The task has been successfully added!");
        break;


        case "2":
            Console.WriteLine("\nHere are the tasks you've previously added:");
            foreach(string tasks in tasksList)
            {
                Console.WriteLine("- " + tasks);
            }
        break;
            
        case "3":
            Console.WriteLine("Type the task you would like to delete: ");
            string deletedTask = Console.ReadLine();
            if (tasksList.Contains(deletedTask)) {
                tasksList.Remove(deletedTask);
                Console.WriteLine("the task has been sucessfully deleted");
            } else if (!tasksList.Contains(deletedTask)) {
                Console.WriteLine("\nthis task doesnt exist in the list");
            }
        break;

        case "4":
            Console.WriteLine("Closing program...");
            Environment.Exit(0);

        break;
    }


}
