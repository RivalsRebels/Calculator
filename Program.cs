using System;

namespace MainCal
{
    public class Program
    {

        static void Main(String[] args)
        {
            Console.Write("Press the First Number: ");
            double Number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Press the Sign: ");
            string op = Console.ReadLine();
            Console.Write("Press the Second Number: ");
            double Number2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine( Number1 + Number2 );
            }
            else if(op == "-")
            {
                Console.WriteLine( Number1 - Number2);
            }
            else if (op == "*")
            {
                Console.WriteLine(Number1 * Number2);
            }



        }



    }
}