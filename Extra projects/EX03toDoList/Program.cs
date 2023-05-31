using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03toDoList
{
    // Task class
    class Task
    {
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public Task(string description)
        {
            Description = description;
            IsDone = false;
        }
    }

    internal class Program
    {
        static List<Task> tasks = new List<Task>();
        static string todoFilePath = "todoList.txt";

        static void Main(string[] args)
        {
            LoadTasks();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Edit Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. View Tasks");
                Console.WriteLine("5. Mark Task as Done");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        EditTask();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        ViewTasks();
                        break;
                    case "5":
                        MarkTaskAsDone();
                        break;
                    case "6":
                        SaveTasks();
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Enter task description:");
            string description = Console.ReadLine();

            Task task = new Task(description);
            tasks.Add(task);

            Console.WriteLine("Task added!");
        }

        static void EditTask()
        {
            Console.WriteLine("Enter task number to edit:");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    Console.WriteLine("Enter new task description:");
                    string newDescription = Console.ReadLine();

                    tasks[taskNumber - 1].Description = newDescription;

                    Console.WriteLine("Task edited successfully!");
                }
                else
                {
                    Console.WriteLine("Wrong task number.");
                }
            }
            else
            {
                Console.WriteLine("Wrong task number format.");
            }
        }

        static void DeleteTask()
        {
            Console.WriteLine("Enter task number to delete:");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);

                    Console.WriteLine("Task deleted!");
                }
                else
                {
                    Console.WriteLine("Wrong task number.");
                }
            }
            else
            {
                Console.WriteLine("Wrong task number format.");
            }
        }

        static void ViewTasks()
        {
            if (tasks.Count > 0)
            {
                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    string status = tasks[i].IsDone ? "Done" : "Pending";
                    Console.WriteLine($"{i + 1}. {tasks[i].Description} - {status}");
                }
            }
            else
            {
                Console.WriteLine("No tasks found.");
            }
        }

        static void MarkTaskAsDone()
        {
            Console.WriteLine("Enter task number to mark as done:");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks[taskNumber - 1].IsDone = true;
                    Console.WriteLine("Task marked as done.");
                }
                else
                {
                    Console.WriteLine("Wrong task number");
                }
            }
            else
            {
                Console.WriteLine("Wrong task number format.");
            }
        }

        static void LoadTasks()
        {
            if (File.Exists(todoFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(todoFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            string description = parts[0];
                            bool isDone = bool.Parse(parts[1]);

                            Task task = new Task(description);
                            task.IsDone = isDone;

                            tasks.Add(task);
                        }
                    }

                    Console.WriteLine("Tasks loaded!");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"An exception while loading tasks: {ex}");
                }
            }
        }
        static void SaveTasks()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(todoFilePath))
                {
                    foreach (Task task in tasks)
                    {
                        string line = $"{task.Description} | {task.IsDone}";
                        writer.WriteLine(line);

                    }
                }
                Console.WriteLine("Tasked saved!");
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Exception {ex} while saving tasks occured");
             }
        }
    }
}
