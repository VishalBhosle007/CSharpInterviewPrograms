# 📘 CSharpInterviewPrograms – C# Interview Programs (Console Application)

## 🔹 Overview
This repository contains a collection of **commonly asked C# interview programs**, implemented using **Console Applications** with a **clean, scalable architecture**.

The goal of this project is to:
- Practice **core C# logic**
- Strengthen **problem-solving skills**
- Maintain a **single, well-organized project** for interview preparation

New programs are added **regularly** as part of daily practice.

---

## 🏗️ Project Structure

```text
Programs
│
└── CSharpPrograms
    │
    ├── ArrayPrograms
    ├── StringPrograms
    ├── NumberPrograms
    ├── PatternPrograms
    │
    ├── IProgram.cs
└── Program.cs
```


### 🔸 Structure Explanation
- **Programs**  
  Root repository folder

- **CSharpPrograms**  
  Main Console Application project

- **Category folders**  
  Programs are grouped by topic for better readability and navigation

- **IProgram.cs**  
  Common interface implemented by all programs

- **Program.cs**  
  Entry point containing the menu-driven execution logic

---

## 🔌 Common Interface (`IProgram`)

All programs implement a single interface:

```csharp
public interface IProgram
{
    string Name { get; }
    void Run();
}
```
**This ensures:**

- Consistent structure across programs

- Easy extensibility

- Clean separation of responsibilities


## ▶️ How the Application Works

- The application uses **reflection** to scan the assembly at runtime  
- All classes implementing `IProgram` are discovered automatically  
- Programs are listed dynamically in a **console-based menu**  
- Selecting a number runs the chosen program  

✔ No hard-coded menu  
✔ No manual registration  
✔ Just add a new class → it appears automatically  

---

## 🧠 Program Categories & Examples

### 🔹 Array Programs
- Bubble Sort
- Remove duplicates from array
- Find maximum and minimum elements
- Find second largest and second smallest
- Reverse array in-place
- Check if two arrays are equal (elements & order)

### 🔹 String Programs
- Reverse string (without built-in methods)
- Remove duplicate characters
- Count character occurrences
- Find first non-repeating character
- Reverse each word in a sentence
- Reverse word order
- Check palindrome string
- Count vowels
- Check if string contains only digits
- Remove white spaces

### 🔹 Number Programs
- Swap numbers (with & without third variable)
- Factorial (loop & recursion)
- Fibonacci series (with & without recursion)
- Prime number check
- Print prime numbers in a range
- Reverse a number
- Sum of digits
- Palindrome number

### 🔹 Pattern Programs
- Right-angled triangle
- Left-angled triangle
- Pyramid (triangle) pattern

---

## 🚀 How to Run the Project

1. Clone the repository
   ```bash
   git clone https://github.com/your-username/Programs.git
   ```
   Open the solution in Visual Studio

2. Build and run the project

3. Select a program from the console menu


## ➕ How to Add a New Program

1. Create a new class in the appropriate category folder

2. Implement the IProgram interface

3. Write logic inside the Run() method

4. Save and run — the program will appear automatically in the menu

 ✅ No changes required in Program.cs



## ⭐ Key Highlights

- Interview-focused C# programs

- Clean and consistent code structure

- Reflection-based menu system

- Easy to extend and maintain

- Suitable for beginners and experienced developers



## 👨‍💻 Author

Vishal Bhosle
