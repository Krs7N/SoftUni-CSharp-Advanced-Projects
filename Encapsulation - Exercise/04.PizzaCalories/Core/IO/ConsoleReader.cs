﻿namespace _04.PizzaCalories.Core.IO
{
    using System;

    using Contracts;
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}