# WinForms Task Manager

A simple Windows Forms (WFA/WinForms) application for managing tasks.  
The goal of this project is to demonstrate practical C# desktop UI skills: event handling, DataGridView usage, CRUD operations, and saving/loading data from a file.

## Features

- Add new tasks (Title, Due Date, Priority, Status)
- View tasks in a DataGridView
- Edit selected task
- Delete selected task
- Mark selected task as Done (button name may appear as "Mark Down" in the UI)
- Save tasks to a JSON file
- Load tasks from a JSON file

## Task Fields

Each task contains:
- **Title** (string)
- **DueDate** (DateTime)
- **Priority** (Low / Medium / High)
- **Status** (New / In Progress / Done)

## Data Storage

Tasks are stored in a JSON file:

- `Data/tasks.json`

The `Data` folder is created automatically if it does not exist.

## How to Run

1. Open the solution/project in Visual Studio (or any compatible IDE).
2. Build the project.
3. Run the application.
4. Use the UI buttons to manage tasks.
5. Use **Save** to store tasks and **Load** to restore them.

## Notes

- The application uses a DataGridView for displaying tasks.
- Input validation is applied (e.g., Title cannot be empty).
- Save/Load are explicit actions via buttons for clarity.

## License

This project is provided for educational purposes without any warranty. Use and modify freely.