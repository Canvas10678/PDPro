using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input your color type of clothes : ");
            string Method = Console.ReadLine();
           
            if (Method == "white")
            {
                Console.WriteLine("Use Haiter to wash clothes ");
            }
            else if (Method == "color")
            {
                Console.WriteLine("Use Breeze Excel Liquid to wash clothes.");
            }
            else
            {
                Console.WriteLine("Use Washing Powder to wash clothes.");
            }
         
            Console.WriteLine("Use Rinse the cloth with water. ");
            Console.WriteLine("Hang clothes on a clothesline.");
            Console.WriteLine("Sterilize and dry completely.");
            Console.WriteLine("Keep it in the closet.");
         
        }
    }
}
