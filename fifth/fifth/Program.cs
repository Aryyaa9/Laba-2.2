using System;
class Practice
{ 
    public string Name { get; set; }
    public int Number { get; set; }
    
    public Practice(string name, int number)
    {
        Name = name;
        Number = number;
    }
    
    public Practice()
    {
        Name = "Name";
        Number = 0;
    }

    // Деструктор
    ~Practice()
    {
        Console.WriteLine("Объект Practice удален из памяти.");
    }

   
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Номер: {Number}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Practice obj1 = new Practice("Привет", 10);
        Console.WriteLine("Объект obj1:");
        obj1.DisplayInfo();

        Console.WriteLine();

        // Создание объекта с использованием конструктора по умолчанию
        Practice obj2 = new Practice();
        Console.WriteLine("Объект obj2 (свойства по умолчанию):");
        obj2.DisplayInfo();
    }
}