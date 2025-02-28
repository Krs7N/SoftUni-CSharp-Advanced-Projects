﻿using System;
using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream source = new FileStream(inputFilePath, FileMode.Open))
            {
                byte[] buffer = new byte[source.Length];

                source.Read(buffer, 0, buffer.Length);

                using (FileStream output = new FileStream(outputFilePath, FileMode.Create))
                {
                    output.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
