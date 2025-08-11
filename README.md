🎓 Student Task Management System (OOP Project)

📌 **Overview**
This project is a console-based C# application for managing students’ academic tasks, supporting both university students and school students.
It demonstrates Object-Oriented Programming (OOP) principles such as interfaces, inheritance, polymorphism, and file handling.

The system allows:

- Adding assignments or projects
- Removing assignments or projects
- Viewing tasks
- Saving student information and tasks into separate files for each student type

📂 **Project Structure**

student_project/

├── IStudent.cs         
├── uniStudent.cs       
├── schoolStudent.cs    
├── student_project.csproj 
|__ program.cs
|__info.cs

⚙️ Features
- Task Management
- Add assignments or projects
- Remove assignments or projects
- View current assignments or projects

- Separate Categories
University Students → Stored in uniStudents/ folder
School Students → Stored in schoolStudents/ folder

- File Management
Saves student details and tasks in .txt files.
Automatically creates directories for each student type.
OOP Principles
Interface (IStudent) for defining required student functionalities.
Inheritance from Info class to share common properties.
Polymorphism to handle multiple student types with the same methods.

