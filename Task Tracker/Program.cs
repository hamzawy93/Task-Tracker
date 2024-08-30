using System.Drawing;

namespace Task_Tracker
{
    internal class Program
    {
        static String[] Tasks = new String[100];
        static int taskindex = 0;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to task tracker v1.0");
            while (true)
            {
                //1.View all tasks
                //2.add new tasks
                //3.mark tasks as complete
                //4.remove tasks
                //5.exit
                
                Console.WriteLine("Enter your choice from 1 to 5 ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1.View all Tasks");
                Console.WriteLine("2.Add New Task ");
                Console.WriteLine("3.Mark Tasks As Complete ");
                Console.WriteLine("4.Remove Tasks ");
                Console.WriteLine("5.Exit ");
                Console.ResetColor();
                String userchoice = Console.ReadLine();
                switch (userchoice)
                {
                    case "1":
                        //view all tasks
                        ViewTasks();
                        break;
                    case "2":
                        //add 
                        AddTask();
                        break;
                    case "3":
                        // mark
                        TaskComplete();
                        break;
                    case "4":
                        //remove
                        TaskDelete();
                        break;

                    case "5":
                        //exit 
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thank your for using...Good Bye ");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter the right choice");
                        break;


                }
            }
        }
        private static void AddTask()
        {
            Console.WriteLine("Enter your task");
            String TaskTitle = Console.ReadLine();
            Tasks[taskindex] = TaskTitle;
            taskindex++;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Task Added ");
            Console.ResetColor ();


        }
        static void ViewTasks()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your Tasks ");
            Console.ResetColor ();
            for (int i = 0; i < taskindex; i++)
            {
                Console.WriteLine($"{ i+1 } + { Tasks[i]}");

            }


        }
        static void TaskComplete()
        {
            Console.WriteLine("Enter Completed Tasks ");
            string tasknumber = Console.ReadLine(); 
            int taskid = int.Parse(tasknumber);
            Tasks[taskid] = Tasks[taskid] +"-------------COMPLETED";
             
        }
        static void TaskDelete()
        {
            Console.WriteLine("Enter Task you want to delete ");
            string tasknumber = Console.ReadLine();
            int taskid = int.Parse(tasknumber);
            Tasks[taskid] = String.Empty;

        }
    }
}
