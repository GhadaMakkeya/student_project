using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class schoolStudent : Info, IStudent
    {


        List<string> Homework = new List<string>();
        List<string> activities = new List<string>();
        public void Add_Task()
        {
            Console.WriteLine("Adding homework and activities...");
            Console.WriteLine("=============");
            Console.Write("If you want to add homework, please enter 1, if you want to add activities, please enter 2: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("If you want to add homework, please enter 1, if you want to add activities, please enter 2: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (choice == 1)
            {
                Console.WriteLine("Please enter the homework you want to add: ");
                string homework = Console.ReadLine();
                Homework.Add(homework);
                Console.Clear();
                Console.WriteLine("Done!");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter the activities you want to add: ");
                string activity = Console.ReadLine();
                activities.Add(activity);
                Console.Clear();
                Console.WriteLine("Done!");
                Console.WriteLine();
            }
        }

        public void Remove_Task()
        {
            Console.WriteLine("=============");
            Console.WriteLine("If you want to remove homework, please enter 1, if you want to remove activities, please enter 2: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("If you want to remove homework, please enter 1, if you want to remove an activity, please enter 2: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (choice == 1)
            {
                Console.WriteLine("Please enter the number of the homework you want to remove: ");
                for (int i = 0; i < Homework.Count; i++)
                    Console.WriteLine($"{i + 1}- {Homework[i]}");
                int index = int.Parse(Console.ReadLine());
                Homework.RemoveAt(index);
                Console.Clear();
                Console.WriteLine("Done!");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter the number of the activity you want to remove: ");
                for (int i = 0; i < activities.Count; i++)
                    Console.WriteLine($"{i + 1}- {Homework[i]}");
                int index = int.Parse(Console.ReadLine());
                Homework.RemoveAt(index);
                Console.Clear();
                Console.WriteLine("Done!");
                Console.WriteLine();
            }
        }

        public void Show_Tasks()
        {
            Console.WriteLine("=============");
            Console.WriteLine("Please enter 1 for homework and 2 for activities: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("If you want to show your homework, please enter 1, if you want to show your activities, please enter 2: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (choice == 1)
            {
                Console.WriteLine("your homework:");
                for (int i = 0; i < Homework.Count; i++)
                    Console.WriteLine($"{i + 1}- homework : {Homework[i]}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("your activities:");
                for (int i = 0; i < activities.Count; i++)
                    Console.WriteLine($"{i + 1}- activity : {activities[i]}");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void CreateStudentFiles(string name, string ID, string email, string password)
        {
            string schoolStudents = "schoolStudents";
            if (!Directory.Exists(schoolStudents))
            {
                Directory.CreateDirectory(schoolStudents);
            }
            string homework = string.Join(", ", Homework);
            string activity = string.Join(", ", activities);

            string filePath = Path.Combine(schoolStudents, $"{ID}.txt");
            string studentData = $"Name : {name}, ID : {ID}, Email : {email}, Password : {password}, Homework : {Homework}, activities : {activities} ";
            File.WriteAllText(filePath, studentData);
            Console.WriteLine($"A file has been created for the student : {name} in {filePath}");
        }
    }
    }
           
    
