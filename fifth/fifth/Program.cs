using System;
class Prаctice : IDisposable
{
    public int Number { get; set; }
    public string Name { get; set; }

    public Prаctice(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public Prаctice()
    {
        Number = 19;
        Name = "World";
    }

    public void DisplayProperties()
    {
        Console.WriteLine($"Объект: {Number}, {Name}");
    }
    
    public void Dispose()
    {
        Console.WriteLine($"Удаленный объект: {Number}, {Name}");
    }
}

class Program
{
    static void Main()
    {
        using (Prаctice obj1 = new Prаctice(3759, "Hello"))
        {
            obj1.DisplayProperties();
        }

        using (Prаctice obj2 = new Prаctice())
        {
            obj2.DisplayProperties();
        }
    }
}
