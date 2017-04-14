using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool run = true;
            
            Console.Write("Please enter an integer between 1 and 10: ");
            do
            {

            long input = Convert.ToInt64(Console.ReadLine());

            long num = input;
  
            for (i = 1; i < input; i++)
            {
                num = num * i;
            }

            Console.WriteLine("\nThe factorial of {0} is {1}: ", input, num);

            Console.Write("\nWould you like to continue?(y/n) ");

            
                string cont = Console.ReadLine();

                if (cont=="y")
                {
                    Console.Write("\n\nPlease enter an integer between 1 and 10: ");
                }

                if(cont == "n")
                {
                    Console.WriteLine("\nThank you!");
                    run = false;
                }

            } while (run == true);

            
        }
        }
     }
    

