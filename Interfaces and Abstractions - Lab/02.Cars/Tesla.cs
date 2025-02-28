﻿using System;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; }

        public string Color { get; }

        public int Battery { get; }

        public string Start() => "Engine start";

        public string Stop() => "Breaaak";

        public override string ToString() => $"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries" + Environment.NewLine + $"{this.Start()}" + Environment.NewLine + $"{this.Stop()}";
        
    }
}