# Student Task Management System (OOP Project)

## Overview
This console-based **C# application** offers a neat way to manage academic tasks for both **university** and **school** students. It’s a solid exercise in **Object-Oriented Programming (OOP)**, emphasizing:

- **Interfaces** (`IStudent`) to define standard behaviors
- **Inheritance** from `Info` to manage shared student properties
- **Polymorphism** to treat different student types uniformly
- **File Handling** to persist student data and tasks in text files

---

## Core Features

- **Task Management**
  - Add assignments or projects
  - Remove tasks when they’re done
  - View current assignments or projects

- **Student Categories**
  - University students → files stored in `uniStudents/`
  - School students → files stored in `schoolStudents/`

- **Automatic File Persistence**
  - Each student’s details and tasks are saved in `.txt` format
  - Directories are created on the fly if they don’t exist

---

## Project Structure

student_project/
- program.cs # Entry point and console menu/controller
- Info.cs # Base class with shared student attributes
- IStudent.cs # Interface declaring student actions
- uniStudent.cs # Implementation for university students
- schoolStudent.cs # Implementation for school students student_project.csproj # Project setup
- uniStudents/ # Output folder for university student files
- schoolStudents/ # Output folder for school student files
---

## How to Run

1. **Clone** or download the repository
2. Open in **Visual Studio** or your preferred C# IDE
3. Make sure the **.NET SDK** is installed
4. **Run** the app via your IDE or use:
---
   ```bash
   dotnet run




