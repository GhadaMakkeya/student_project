using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_Project
{

    class uniStudent : Info, IStudent
    {
        List<string> assignments = new List<string>();
        List<string> projects = new List<string>();

        public void Add_Task()
        {
            Console.WriteLine("Adding assignments and projects to your uni schedule...");
            Console.WriteLine("=============");
            Console.WriteLine("if you want to add an assignment, please enter 1, if you want to add a project, please enter 2:");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("If you want to add an assignment, please enter 1, if you want to add a project, please enter 2: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (choice == 1)
            {
                Console.Write("please enter the assignment you want to add:");
                string assignment = Console.ReadLine();
                assignments.Add(assignment);
            }
            else if (choice == 2)
            {
                Console.Write("please enter the project you want to add:");
                string project = Console.ReadLine();
                projects.Add(project);
            }
            Console.Clear();
            Console.WriteLine("Done!");
            Console.WriteLine();
        }

        public void Remove_Task()
        {
            Console.WriteLine("=============");
            Console.WriteLine("please enter the number of the task you want to remove:");
            Console.WriteLine("Please enter 1 for assignments and 2 for projects:");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("If you want to remove an assignment, please enter 1, if you want to remove a project, please enter 2: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (choice == 1)
            {
                Console.WriteLine("Please enter the number of the assignment you want to remove:");
                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine($"{i} {assignments[i]}");
                }
                int index = int.Parse(Console.ReadLine());
                assignments.RemoveAt(index);
            }
            if (choice == 2)
            {
                Console.WriteLine("Please enter the number of the project you want to remove:");
                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine($"{i} {assignments[i]}");
                }
                int index = int.Parse(Console.ReadLine());
                assignments.RemoveAt(index);
            }
            Console.Clear();
            Console.WriteLine("Done!");
            Console.WriteLine();
        }

        public void Show_Tasks()
        {
            Console.WriteLine("=============");
            Console.WriteLine("Please enter 1 for assignments and 2 for projects:");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("If you want to show your assignments, please enter 1, if you want to show your projects, please enter 2: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (choice == 1)
            {
                Console.WriteLine("your assignments:");
                for (int i = 0; i < assignments.Count; i++)
                    Console.WriteLine($"{i + 1}-assignment : {assignments[i]}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("your projects:");
                for (int i = 0; i < projects.Count; i++)
                    Console.WriteLine($"{i + 1}-project :  {projects[i]}");
            }
            Console.ReadKey();
            Console.Clear();
          }

            public void CreateStudentFiles(string name, string ID, string email, string password)
            {

                string uniStudents = "uniStudents";
                if (!Directory.Exists(uniStudents))
                {
                    Directory.CreateDirectory(uniStudents);
                }                
                 string assignment = string.Join(", ", assignments);
                 string project = string.Join(", ", projects);

                string filePath = Path.Combine(uniStudents, $"{ID}.txt");
                string studentData = $"Name : {name}, ID : {ID}, Email : {email}, Password : {password} assignments : {assignment}, projects : {project}";
                File.WriteAllText(filePath, studentData);
                Console.WriteLine($"A file has been created for the student : {name} in {filePath}");
            }
        }
    }



