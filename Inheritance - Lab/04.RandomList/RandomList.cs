﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            int index = random.Next(0, Count);

            string removedElement = this[index];

            Remove(removedElement);

            return removedElement;
        }
    }
}