using System;
class Numbers
{ 
    public int Num1 { get; set;}
    public int Num2 { get; set;}
    
    public Numbers(int number1, int number2)
    {
        Num1 = number1;
        Num2 = number2;
    }
    public void DisplayNumbers()
    {
        Console.WriteLine($"Число 1: {Num1}");
        Console.WriteLine($"Число 2: {Num2}");
    }
    public void ChangeNumbers(int newNum1, int newNum2)
    {
        Num1 = newNum1;
        Num2 = newNum2;
    }
    public int SumOfNumbers()
    {
        return Num1 + Num2;
    }
    public int MaxNumber()
    {
        return Math.Max(Num1, Num2);
    }
}

class Program
{
    static void Main()
    {
        Numbers numbers = new Numbers(5, 178);

        Console.WriteLine("\nИсходные числа:");
        numbers.DisplayNumbers();

        Console.WriteLine("\nВведите новые значения чисел:");
        Console.Write("Число 1: ");
        int newNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Число 2: ");
        int newNumber2 = Convert.ToInt32(Console.ReadLine());
        
        numbers.ChangeNumbers(newNumber1, newNumber2);

        Console.WriteLine("\nИзмененные числа:");
        numbers.DisplayNumbers();
        
        Console.WriteLine($"\nСумма чисел: {numbers.SumOfNumbers()}");
        Console.WriteLine($"Наибольшее число: {numbers.MaxNumber()}");
    }
}
