using System;
class Counter
{
    int value; 
    public Counter()
    {
        value = 0; 
    }
   
    public Counter(int startValue)
    {
        value = startValue;
    }
    
    public void Increment()
    {
        value++;
    }
    
    public void Decrement()
    {
        value--;
    }
    
    //Св-во для получения текущего значения счетчика
    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main()
    {
        Counter counter1 = new Counter();
        
        counter1.Increment();
        Console.WriteLine("Значение счетчика 1 после увеличения: " + counter1.Value);
        
        Counter counter2 = new Counter(109);
        
        counter2.Decrement();
        Console.WriteLine("Значение счетчика 2 после уменьшения: " + counter2.Value);
    }
}
