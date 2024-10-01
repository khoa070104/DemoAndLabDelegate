using System;

namespace Lab4.Delegate_Q1
{
    public delegate void SampleDelegate(int a, int b);

    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract Result: {0}", a - b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply Result: {0}", a * b);
        }

        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Divide Result: {0}", a / b);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Delegate Example****");
            MathOperations mathOperations = new MathOperations();

            SampleDelegate dlgt = mathOperations.Add;

            dlgt += mathOperations.Subtract;
            dlgt += mathOperations.Multiply;
            dlgt += mathOperations.Divide;

            dlgt(100, 20);

            Console.ReadLine();
        }
    }
}
