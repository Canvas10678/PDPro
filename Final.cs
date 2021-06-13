using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int item; string Name, Type;
             Console.Write("Number of Item : ");
             item = int.Parse(Console.ReadLine());
             Console.Write("Item :");
             Name = Console.ReadLine();
             Console.Write("Type : ");
             Type = Console.ReadLine();

             Console.Write("Search item : ");
             string Search = Console.ReadLine();
             string[,] itemsArray = new string[4, 2] { { "LongSword","Weapon" },
                                                      { "ShortSword" , "Weapon" },
                                                      { "Lollipop","Snack" },
                                                      { "GrilledFish","Food" } };
            while (true)
            {
                if (Search == "ShowAll")
                {
                    for (int c = 0; c < item; c++)
                    {
                        for (int r = 0; r < 2; r++)
                        {
                            Console.WriteLine("{0}", itemsArray[c, r]);
                        }
                    }
                    Console.WriteLine();
                }
                for (int c = 0; c < item; c++)
                {
                    if (Search == itemsArray[c, 0])
                    {
                        for (int r = 0; r < item; r++)
                        {
                            Console.WriteLine("{0}", itemsArray[r, 0]);
                        }
                        Console.WriteLine();
                    }

                }
                for (int r = 0; r < item; r++)
                {
                    if (Search == itemsArray[r, 0])
                    {
                        for (int c = 0; c < item; c++)
                        {
                            Console.WriteLine("{0}", itemsArray[c, 0]);
                        }
                        Console.WriteLine();
                    }

                }

            }
             else
                 {
                     Console.WriteLine("End");
                 }

             }
         }
           


          





          
