using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Project
{
    class Info
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public void studentInputDetails(ref uniStudent uni_student, ref schoolStudent school_student)
        {

            Console.Write("Please enter your name:");
            Name = Console.ReadLine();
            Console.Clear();

            Console.Write("Please enter your uni ID, it should be 6 digits long:");
            string Id = (Console.ReadLine());
            while (!isValidID(Id))
            {
                Console.WriteLine("Invalid ID!");
                Console.Clear();
                Console.Write("Please try again:");
                Console.Write("Please enter your school ID, it should be 6 digits long:");
                Id = (Console.ReadLine());
            }
            ID = Id;
            Console.WriteLine("Valid!");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please enter your Email:");
            string email = Console.ReadLine();
            while (!isValidEmail(email))
            {
                Console.WriteLine("Invalid Email!");
                Console.Clear();
                Console.WriteLine("Please try again:");
                Console.Write("Please enter your Email:");
                email = Console.ReadLine();
            }
            Email = email;
            Console.WriteLine("Valid!");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please enter your password, it should be at least 8 characters long (Digits & letters):");
            string password = Console.ReadLine();
            while (!isValidPassword(password))
            {
                Console.WriteLine("Invalid Password!");
                Console.WriteLine("Please try again:");
                Console.Write("Please enter your password, it should be at least 8 characters long (Digits & letters):");
                password = Console.ReadLine();

            }
            Password = password;
            Console.WriteLine("Valid!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Your info is saved succsesfully!");
            Console.ReadKey();
            Console.Clear();
        }
        static bool isValidID(string ID)
        {
            if (ID.Length != 6)
                return false;
            return true;
        }
        static bool isValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;
            if (password.Length < 8)
                return false;
            if (!password.Any(char.IsLetter))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            return true;
        }
        static bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }



        public void storeEmail()
        {
            File.WriteAllText($"{Name}_email.txt", Email);
        }
        public void storePassword()
        {
            File.WriteAllText($"{Name}_password.txt", Password);
        }
        public void storeID()
        {
            File.WriteAllText($"{Name}_ID.txt", ID);
        }

    }

 }

