﻿namespace _04.BorderControl.IO.Contracts
{
    public interface IWriter
    {
        void Write(object value);

        void WriteLine(object value);
    }
}