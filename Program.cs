using System;
using System.Text.RegularExpressions;

namespace taskManager
{
    class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Please enter 1 if you are a university student or 2 if you are a school student");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 1 || choice != 2)
            {
                if (choice == 1)
                {
                    Console.WriteLine("You selected university student!");
                    uniStudent student = new uniStudent();
                    Console.WriteLine("Please enter your name");
                    student.name = Console.ReadLine();
                    Console.WriteLine("Please enter your uni ID");
                    student.ID = Console.Readline();
                    Console.WriteLine("Please enter your Email");
                    email = Console.ReadLine();
                    while (!isValidEmail(Email))
                    {
                        Console.WriteLine("Invalid Email!");
                        Console.WriteLine("Please try again");
                        email = Console.ReadLine();
                    }
                    student.Email = email;
                    Console.WriteLine("Valid!");
                    Console.WriteLine("Please enter your password");
                    student password = Console.Readline();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You selected school student!");
                    schoolStudent student = new schoolStudent();
                }
                else
                    Console.WriteLine("Invalid option");
            }
            static bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }

        }
    }
    interface IStudent
    {

    }

    class uniStudent : IStudent
    {
        public string name { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

    }
  }

   