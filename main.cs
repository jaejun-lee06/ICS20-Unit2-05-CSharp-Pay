// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area and perimeter of a triangle
        float hours;
        float hourlyrate;
        Console.WriteLine("Enter number of hours worked:");
        hours = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter hourly rate:");
        hourlyrate = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Your pay will be: $" + ((hours * hourlyrate) * (1 - 0.18)).ToString("0.00") + ".");
        Console.WriteLine("The government will take: $" + ((hours * hourlyrate) * 0.18).ToString("0.00") + ".");
        Console.WriteLine("\nDone.");
    }
}