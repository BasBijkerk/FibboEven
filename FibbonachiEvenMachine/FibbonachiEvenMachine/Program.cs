using System;

namespace FibbonachiEvenMachine
{
    class Program
    {
        static int Endval = 0;
        static int firstval = 1;
        static int secondval = 2;
        static int calcval = 0;
        static int calcresult = 2 ;
        static void Main(string[] args)
        {
            Console.WriteLine("Fibbonachi even machine");
            Console.WriteLine("Please enter End Value(Number below wich the program will keep doing calculations)");
            Endval = Convert.ToInt32(Console.ReadLine());
            while(calcval < Endval)
            {
                calcval = firstval + secondval;
                firstval = secondval;
                secondval = calcval;
                if(calcval%2 == 0 && calcval < Endval)
                {
                    Console.WriteLine("Even Number: " + calcval);
                    calcresult += calcval;
                }
                
            }
            Console.WriteLine("Result: " + calcresult);
        }
    }
}
