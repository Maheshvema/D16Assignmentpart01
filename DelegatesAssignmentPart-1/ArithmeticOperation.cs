using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignmentPart_1
{
    internal delegate int ArithmeticOperation(int a, int b);

    
    internal class Arithmeticoperation
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            ArithmeticOperation addOperation = Add;
            ArithmeticOperation subtractOperation = Subtract;
            ArithmeticOperation multiplyOperation = Multiply;
            ArithmeticOperation divideOperation = Divide;
            Console.WriteLine("Enter the first number:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the user option to operation:");
            Console.WriteLine("1.Add 2.sub 3.mul 4.Div");
            int op=int.Parse(Console.ReadLine());
            int result;
            switch(op)
            {
                case 1:
                    {
                        result = addOperation(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    }
                case 2:
                    {
                        result = subtractOperation(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    }
                case 3:
                    {
                        result = multiplyOperation(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    }
                case 4:
                    {
                        result = divideOperation(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
            }
            Console.ReadKey();           
        }
    }
}
