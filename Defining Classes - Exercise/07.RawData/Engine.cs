﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Engine
    {
        private int speed;

		private int power;

		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

        public int Power
		{
			get { return power; }
			set { power = value; }
		}
    }
}
