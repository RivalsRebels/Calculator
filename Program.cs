namespace MainCalculator
{
    public class MainProgram
    {

        static void Main(String[] args)
        {
            try
            {
                Console.Write("Press the First Number: ");
                double Number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Press the Sign: ");
                string Operator = Console.ReadLine();

                Console.Write("Press the Second Number: ");
                double Number2 = Convert.ToDouble(Console.ReadLine());

                if (Operator == "+")
                {
                    Console.WriteLine(Number1 + Number2);
                }

                else if (Operator == "-")
                {
                    Console.WriteLine(Number1 - Number2);
                }

                else if (Operator == "*")
                {
                    Console.WriteLine(Number1 * Number2);
                }

                else if (Operator == "/")
                {
                    Console.WriteLine(Number1 / Number2);
                }

                if (Operator != null)
                {
                    throw new FormatException();
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}