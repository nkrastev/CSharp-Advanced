﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        //fields
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        //constructors
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption,
            Engine engine,
            Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }


        //properties
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        //methods
        public void Drive(double distance)
        {
            if (this.FuelQuantity - distance/100 * this.FuelConsumption > 0)
            {
                this.FuelQuantity -= this.FuelConsumption * distance/100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string PrintDetails()
        {
            return $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n" +
                $"Year: {this.Year}\n" +
                $"HorsePowers: {this.Engine.HorsePower}\n" +
                $"FuelQuantity: {this.FuelQuantity}";
        }
        public string WhoAmI()
        {
            string result = $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
            return result;
        }

        public double SumTirePressure()
        {
            var sum = 0.0;
            for (int i = 0; i < Tires.Length; i++)
            {
                sum += Tires[i].Pressure;
            }
            return sum;
        }
    }
}
