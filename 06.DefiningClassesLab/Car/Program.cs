﻿using System;

namespace CarManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Toyota";
            car.Model = "Aurius";
            car.Year = 2007;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

        }
    }
}
