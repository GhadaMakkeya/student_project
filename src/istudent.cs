using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace OOP_Project
    {
        interface IStudent
       
        {
       
            void Add_Task();
            void Remove_Task();
            void Show_Tasks();
            void CreateStudentFiles(string name, string ID, string email, string password);

        }
    }
