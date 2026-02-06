# 🧠 ITI Examination System

A desktop-based **Examination Management System** built with **C#** and **Microsoft SQL Server** that allows instructors to create exams and students to take them.

---

## ✨ System Overview

The system supports:

- ✔ Instructor exam generation
- ✔ Multiple Choice & True/False questions
- ✔ Timed exams
- ✔ Automatic submission
- ✔ Result tracking

---

## 👩‍🏫 Instructor Features

- Login with credentials
- View assigned courses
- Generate exams (MCQ & True/False)
- Show exam questions
- View student grades

---

## 👨‍🎓 Student Features

- Login with credentials
- View available exams
- Take exam with timer
- Auto submit when time ends
- View results

---

## 🗂 Database Structure

### Tables

- Questions
- Choices
- Exams
- Students
- Teachers
- StudentAnswers

### Notes

- ✔ True/False questions are stored with **two choices**: `True / False`
- ✔ Questions and their choices are linked using **QuestionNumber**

---

## 🧪 Sample SQL Inserts

### Insert Questions

```sql
INSERT INTO Questions (QuestionNumber, QuestionText, QuestionType, CorrectAnswer) VALUES
(1, 'C# is a statically-typed programming language.', 0, 'True'),
(2, 'Python is a compiled language.', 0, 'False');
```

---

## 📊 Database Design

All database design files are located in the **DataBase** folder.

### 📈 ERD Diagram

- [View ERD](./DataBase/ProjectERD.drawio.pdf)

### 🧩 Database Mapping

- [View Mapping](./DataBase/Mapping.pdf)

### 📖 Database Documentation

- [View Documentation](./Documentation/ITIDBProj.pdf)

---

## ⚙️ Dependencies

- .NET Framework
- Microsoft SQL Server
- SQL Server Management Studio (optional)

---

## 🔄 System Flow

### 👩‍🏫 Instructor Flow

1. Login
2. Select course
3. Generate exam
4. View / Print questions
5. View student grades

### 👨‍🎓 Student Flow

1. Login
2. Select available exam
3. Take exam
4. View result
