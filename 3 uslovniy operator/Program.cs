﻿using System;

namespace _3_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 5;
            int zoomStep = 7;
            int finalValue = 96;

            for (int i = startingNumber; i <= finalValue; i += zoomStep)
            {
                Console.Write(i + " ");
            }
        }
    }
}
