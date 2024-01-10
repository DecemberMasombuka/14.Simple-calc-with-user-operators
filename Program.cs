using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Simple_calc_with_user_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator(+,-,/ ,*,%)");
            String op = Console.ReadLine();

            Console.WriteLine("Enter a second  number");
            double num2  = Convert.ToDouble(Console.ReadLine());



            if (op == "+")
            {
                result = (num1 + num2);
            }
            else if (op == "-")
            {
                result = (num1 - num2);
            }
            else if (op == "*")
            {
                result = (num1 * num2);
            }
            else if (op == "/")
            {
                result = (num1 / num2);
            }
            else if (op == "%")
            {
                result = (num1 % num2);
            }else

            {
                Console.WriteLine("NO OPERATOR CHOOSEN");
           
            }

                Console.WriteLine(result);
                Console.Read();
            
        }
    }
}
