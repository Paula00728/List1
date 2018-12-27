using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_1
{
    class ChristmasTree : Program
    {      
        public static string userInput;
        public static int weight;

        public void BasicProgram()
        {
            Console.WriteLine("Christmas Tree");
            Console.WriteLine("Christmas tree weight");
            userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You must select christmas tree weight");
            }

            else
            {
                weight = int.Parse(userInput);
                PaintChristmasTree(weight);
            }
        }

        void PaintChristmasTree(int weight)
        {
            int counter = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= weight; i++)
            {    
                {
                    for (int j = 1; j <= weight + i - 1; j++)
                        if (j > weight - i)
                        {
                            if(counter%2==0)
                                Console.Write("*");
                            else
                            {
                                Console.Write(" ");
                            }
                            counter++;
                        }
                        else
                            Console.Write(" ");
                    Console.WriteLine();
                    counter = 1;
                }
            }
            for (int j = 0; j < 1; j++)
            {
                for (int i = 0; i < weight - 1; i++)
                {
                    Console.Write(" ");
                }
            }

        }
    }
}
    
