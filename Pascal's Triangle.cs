using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            do
            {
                Console.Write("Pascal's Triangle Size: ");
                int ans = 1, b, u;
                 Num = int.Parse(Console.ReadLine());
                
                if (Num < 0)
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                    Console.WriteLine("Please enter again");
                }
                else 
                {

                    for (b = 0; b <= Num; b++)
                    {
                        for (u = 0; u <= b; u++)
                        {
                            if (u == 0 || b == 0)
                                ans = 1;
                            else
                                ans = ans * (b - u + 1) / u;
                            Console.Write(ans + " ");
                        }
                        Console.ReadLine();
                    }
                }
            } while (Num < 0);

        }
    }
}

    

