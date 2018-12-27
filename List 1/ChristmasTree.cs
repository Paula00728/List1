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
        public static int height;

        public void BasicProgram()
        {
            Console.WriteLine("Christmas Tree");
            Console.WriteLine("Christmas tree height");
            userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("You must select christmas tree height");
            }

            else
            {
                height = int.Parse(userInput);
                PaintChristmasTree(height);
            }
        }

        void PaintChristmasTree(int height)
        {
            int counter = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i <= height; i++)
            {    
                {
                    for (int j = 0; j <= height + i; j++)
                        if (j > height - i)
                        {
                            if(counter%2==1)
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
        }
    }
}
    
