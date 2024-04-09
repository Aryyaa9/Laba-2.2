using System;
class Prictice : IDisposable
{
    public int Number { get; set; }
    public string Name { get; set; }

    public Prictice(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public Prictice()
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
        using (Prictice obj1 = new Prictice(3759, "Hello"))
        {
            obj1.DisplayProperties();
        }

        using (Prictice obj2 = new Prictice())
        {
            obj2.DisplayProperties();
        }
    }
}
