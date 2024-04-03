using System;
using System.Collections.Generic;
class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }
}

class Program
{
    static void Main()
    {
        List<Train> trains = new List<Train>
        {
            new Train { Destination = "Москва", TrainNumber = 1, DepartureTime = new DateTime(2024, 4, 3, 8, 0, 0) },
            new Train { Destination = "Уфа", TrainNumber = 2, DepartureTime = new DateTime(2024, 4, 3, 9, 0, 0) },
            new Train { Destination = "Новосибирск", TrainNumber = 3, DepartureTime = new DateTime(2024, 4, 3, 10, 0, 0) }
        };
        
        Console.Write("Введите номер поезда (Номера: 1, 2, 3): ");
        int selectedTrainNumber = Convert.ToInt32(Console.ReadLine());

        Train selectedTrain = trains.Find(train => train.TrainNumber == selectedTrainNumber);
        if (selectedTrain != null)
        {
            Console.WriteLine($"\nИнформация о поезде №{selectedTrain.TrainNumber}:");
            Console.WriteLine($"Направление: {selectedTrain.Destination}");
            Console.WriteLine($"Время отправления: {selectedTrain.DepartureTime}");
        }
        else
        {
            Console.WriteLine("Поезд с таким номером не найден.");
        }
    }
}