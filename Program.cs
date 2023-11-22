// Program.cs
using Assignmnet18;
using System;

class Program
{
    static void Main()
    {
        // Create instances
        Smartphone myPhone = new Smartphone("SmartPhone");
        Laptop myLaptop = new Laptop("Laptop");

        // Demonstrate usage of interfaces
        myPhone.Connect();
        myPhone.Charge(30);
        Console.WriteLine(myPhone.Display());

        Console.WriteLine();

        myLaptop.Connect();
        myLaptop.Charge(45);
        Console.WriteLine(myLaptop.Display());
    }
}
