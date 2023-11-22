// Smartphone.cs
using Assignmnet18;
using System;

public class Smartphone : IConnectable, IRechargeable, IDisplayable
{
    public string Model { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryPercentage { get; private set; }

    public Smartphone(string model)
    {
        Model = model;
    }

    public bool Connect()
    {
        // Implement connection logic
        IsConnected = true;
        Console.WriteLine($"{Model} is connected.");
        return IsConnected;
    }

    public void Charge(int minutes)
    {
        // Implement charging logic
        BatteryPercentage += minutes;
        Console.WriteLine($"{Model} is charged for {minutes} minutes. Battery percentage: {BatteryPercentage}%");
    }

    public string Display()
    {
        // Implement display logic
        return $"{Model} display information: {BatteryPercentage}% battery";
    }
}
