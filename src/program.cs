using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


namespace OOP_Project
{
    class Program
    {
        static uniStudent uni_student;
        static schoolStudent school_student;
        static void Main(string[] args)
        {
            Console.Write("Please enter 1 if you are a university student or 2 if you are a school student:");
            int studiesChoice = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();
            string taskChoice = "";
            while (studiesChoice != 1 && studiesChoice != 2)
            {
                Console.WriteLine("Invalid choice!,Please enter 1 or 2");
                studiesChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            if (studiesChoice == 1)
            {
                Console.WriteLine("You selected university student!");
                Console.ReadKey();
                Console.Clear();
                uni_student = new uniStudent();
                uni_student.studentInputDetails(ref uni_student, ref school_student);
                choosingOption(ref uni_student, ref school_student);
                uni_student.CreateStudentFiles(uni_student.Name,uni_student.ID, uni_student.Email, uni_student.Password);

                //=================//

            }
            else if (studiesChoice == 2)
            {
                Console.WriteLine("You selected school student!");
                school_student = new schoolStudent();
                Console.ReadKey();
                Console.Clear();

                school_student.studentInputDetails(ref uni_student, ref school_student);
                choosingOption(ref uni_student, ref school_student);
                school_student.CreateStudentFiles(school_student.Name, school_student.ID, school_student.Email, school_student.Password);


            }
                void choosingOption(ref uniStudent uni_student, ref schoolStudent school_student)
                {

                    while (taskChoice != "4")
                    {
                        Console.WriteLine("What do you want to do:");
                        Console.WriteLine("(1) Add a task");
                        Console.WriteLine("(2) Remove a task");
                        Console.WriteLine("(3) show tasks");
                        Console.WriteLine("(4) to exit!");
                        Console.WriteLine("==============");
                        Console.Write("Enter the number:");
                        taskChoice = Console.ReadLine();
                        Console.Clear();

                        switch (taskChoice)
                        {
                            case "1":
                                if (studiesChoice == 1)
                                    uni_student.Add_Task();
                                else if (studiesChoice == 2)
                                    school_student.Add_Task();
                                break;
                            case "2":
                                if (studiesChoice == 1)
                                    uni_student.Remove_Task();
                                else if (studiesChoice == 2)
                                    school_student.Remove_Task();
                                break;
                            case "3":
                                if (studiesChoice == 1)
                                    uni_student.Show_Tasks();
                                else if (studiesChoice == 2)
                                    school_student.Show_Tasks();
                                break;
                            case "4":
                                Console.WriteLine("Thanks for using the program,see you next time.");
                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine("invalid number");
                                break;
                        }
                    }
                }
                
            }
        }
    }


    

        
