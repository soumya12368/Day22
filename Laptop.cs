// Laptop.cs

using System;
using Assignmnet18;
public class Laptop : IConnectable, IRechargeable, IDisplayable
{
    public string Brand { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryPercentage { get; private set; }

    public Laptop(string brand)
    {
        Brand = brand;
    }

    public bool Connect()
    {
        // Implement connection logic
        IsConnected = true;
        Console.WriteLine($"{Brand} Laptop is connected.");
        return IsConnected;
    }

    public void Charge(int minutes)
    {
        // Implement charging logic
        BatteryPercentage += minutes;
        Console.WriteLine($"{Brand} Laptop is charged for {minutes} minutes. Battery percentage: {BatteryPercentage}%");
    }

    public string Display()
    {
        // Implement display logic
        return $"{Brand} Laptop display information: {BatteryPercentage}% battery";
    }
}
