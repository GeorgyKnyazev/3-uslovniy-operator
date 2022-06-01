using System;

namespace _3_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 5;
            int zoomStep = 7;
            
            while (startingNumber < 100)
            {
                Console.Write(startingNumber + " ");
                startingNumber += zoomStep;
            }
        }
    }
}
