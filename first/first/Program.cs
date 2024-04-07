using System;
class Student
{
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public Student(string lastName, DateTime dateOfBirth, string groupNumber, int[] grades)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
        SetGrades(grades);
    }

    // Фукция для изменения успеваемости
    public void SetGrades(int[] newGrades)
    {
        if (newGrades.Length == 5)
        {
            Grades = newGrades;
        }
        else
        {
            Console.WriteLine("Успеваемость должна содержать 5 оценок.");
        }
    }

    // Функция для вывода информации о студенте
    public void PrintInfo()
    {
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Дата рождения: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
        Console.WriteLine("Успеваемость:");
        for (int i = 0; i < Grades.Length; i++)
        {
            Console.WriteLine($"Оценка {i + 1}: {Grades[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Петров", new DateTime(2002, 5, 15), "Группа 102", new int[] { 5, 4, 5, 3, 4 });

        Console.WriteLine("Информация о студенте:");
        student.PrintInfo();

        Console.WriteLine("\nВведите новую фамилию студента:");
        string newLastName = Console.ReadLine();
        student.LastName = newLastName;

        Console.WriteLine("\nВведите новую дату рождения студента (гггг-мм-дд):");
        DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
        student.DateOfBirth = newDateOfBirth;

        Console.WriteLine("\nВведите новый номер группы студента:");
        string newGroupNumber = Console.ReadLine();
        student.GroupNumber = newGroupNumber;

        Console.WriteLine("\nОбновленная информация о студенте:");
        student.PrintInfo();
    }
}
