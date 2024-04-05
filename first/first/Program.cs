using System;
class Student
{
    private string lastName;
    private DateTime dateOfBirth;
    private string groupNumber;
    private int[] grades;
    
    public Student(string lastName, DateTime dateOfBirth, string groupNumber, int[] grades)
    {
        this.lastName = lastName;
        this.dateOfBirth = dateOfBirth;
        this.groupNumber = groupNumber;
        this.grades = grades;
    }
    
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public string GroupNumber
    {
        get { return groupNumber; }
        set { groupNumber = value; }
    }

    // Метод для изменения успеваемости
    public void SetGrades(int[] newGrades)
    {
        if (newGrades.Length == 5)
        {
            grades = newGrades;
        }
        else
        {
            Console.WriteLine("Ошибка: Успеваемость должна содержать 5 оценок.");
        }
    }

    
    public void PrintInfo()
    {
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Дата рождения: {dateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Номер группы: {groupNumber}");
        Console.WriteLine("Успеваемость:");
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Оценка {i + 1}: {grades[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Иванов", new DateTime(2000, 5, 15), "Группа 101", new int[] { 5, 4, 5, 3, 4 });
        
        
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
