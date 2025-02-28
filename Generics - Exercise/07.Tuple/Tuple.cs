﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<T1, T2>
    {
        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Item1} -> {Item2}");

            return sb.ToString().Trim();
        }
    }
}