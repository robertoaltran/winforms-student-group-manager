# WinForms Student Group Manager

This is a C# Windows Forms application developed to manage student entries and their assigned groups. It features a graphical interface allowing users to add students, assign them to groups, and display a list of all current students.

## 📂 Project Structure

The main components of the application include:

- `Form1.cs`: Contains the logic for the user interface (UI) events and interaction.
- `Form1.Designer.cs`: Responsible for the visual layout of the application using Windows Forms.
- `Program.cs`: The entry point of the application.
- `Group.cs`: Represents a group that students can belong to.
- `GroupType.cs`: Represents different types or categories of groups.
-  Youtube link: https://youtu.be/A44VVTINI9M

## 🖥️ How It Works

- The application loads a Windows Form UI with:
  - A button to add new students (`Add Students`)
  - A button to show the list of students (`Show Students`)
  - A `DataGridView` to display the student data

When the user clicks **Add Students**, a new student (with pre-defined or random details in the current logic) is added to the internal list. When the user clicks **Show Students**, all the student data is displayed in the table.

## ✅ Features

- Event-driven design using `Button.Click` events
- Dynamic `DataGridView` population
- Object-Oriented Design with encapsulated class structures (`Group`, `GroupType`)
- Modular, clean, and maintainable codebase

## 🚀 Technologies Used

- **Language**: C#
- **Framework**: .NET Windows Forms
- **IDE**: Visual Studio or Visual Studio Community via Parallels (for Mac users)

## 🔧 How to Run

1. Clone the repository or download the ZIP.
2. Open the `.csproj` file in Visual Studio (Windows).
3. Press `F5` or click `Start` to build and run the application.

## 📚 What I Learned

- Designing and laying out GUI using Windows Forms
- Creating and connecting multiple C# classes
- Managing UI interactions through event handlers
- Displaying tabular data using `DataGridView`
- Understanding how forms communicate with backend logic

---