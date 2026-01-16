using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp20
{

    internal class Calculator
    {
        // Properties to store calculator values 
        public double Add { get; set; }
        public double Subtract { get; set; }
        public double Multiply { get; set; }
        public double Divide { get; set; }

        // Constructor to initialize calculator properties
        public Calculator(double add, double subtract, double multiply, double divide)
        {
            Add = add;
            Subtract = subtract;
            Multiply = multiply;
            Divide = divide;
        }
        // Method to add two numbers entered by the user
        public void AddNumbers()
        {

            {
                Console.WriteLine("enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the second number");
                int num2 = int.Parse(Console.ReadLine());

                int sum = num1 + num2;
                Console.WriteLine("sum is :" + sum);
            }

        }
        public void SubtractNumbers()
        {
            {
                Console.WriteLine("enter the first number ");
                double num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the second number");
                double num2 = Convert.ToInt32(Console.ReadLine());

                double sum = num1 - num2;
                Console.WriteLine("the sum is :" + sum);
            }
        }
        public void MultiplyNUmbers()
        {
            Console.WriteLine("enter first number ");
            double num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number ");
            double num2 = int.Parse(Console.ReadLine());

            double sum = num1 * num2;
            Console.WriteLine("the sum is :" + sum);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            double add = 0;
            double subtract = 0;
            double multiply = 0;
            double divide = 0;
            Calculator calc = new Calculator(add, subtract, multiply, divide);

            while (true)
            {
                calc.AddNumbers();
                Console.WriteLine("do you want to add again (yes/no)");
                string choice = Console.ReadLine().ToLower();

                if(choice != "yes")
                {
                    break;
                }
            }

            while (true)
            {
                calc.SubtractNumbers();
                Console.WriteLine("do you want to subtract again (yes/no)");

                string choice = Console.ReadLine().ToLower();

                if (choice != "yes")
                {
                    break;
                }
            }

            while (true)
            {
                calc.MultiplyNUmbers();
                Console.WriteLine("do you want to multiply again (yes/no)");

                string choice = Console.ReadLine().ToLower();

                if (choice != "yes")
                {
                    break;
                }
            }
        }
    }
}