using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignmentPart_1
{
    internal delegate int ArithmeticOperation(int x, int y);
    internal class Arithmeticoperation
    {
        static void Main(string[] args)
        {
            ArithmeticOperation operation  ;
            Console.WriteLine("Enter the first number:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the user option to operation:");
            Console.WriteLine("1.Add 2.sub 3.mul 4.Div");
            int op=int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        operation = (a, b) => a + b;
                        break;
                    }
                case 2:
                    {
                       operation = (a, b) => a - b;
                        break;
                    }
                case 3:
                    {
                       operation = (a, b) => a * b;
                        break;
                    }
                case 4:
                    {
                       operation = (a, b) => a / b;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
            }
            int result = operation(num1, num2);
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();           
        }
    }
}
