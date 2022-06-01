using System;

namespace _3_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 5;
            int zoomStep = 7;
            int finalValue = 96;            
            
            while (startingNumber <= 96)
            {
                Console.Write(startingNumber + " ");
                startingNumber += zoomStep;
            }
        }
    }
}
