using System;

namespace sturday_yaya
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Z, W, S;

            Console.Write("Input your Mode : ");
            string Mode = Console.ReadLine();
            Console.Write("Input your X : ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Input your Y : ");
            Y = double.Parse(Console.ReadLine());
            Z = Math.Pow(X - 1, 2);
            W = Math.Sqrt(Y) + 1 ;
            S = -Math.Sqrt(Y) + 1;

            switch (Mode)
            {
                case "Time":
                    if (X < 0) //เช็คกรณี time
                        { Console.WriteLine("Invaild mouse position"); }
                    else if (X >= 0)
                        { Console.WriteLine("Your output is ({0},{1})", X, Z); }
                    break;
                case "Price":
                    if (X < 0)
                    { Console.WriteLine("Invaild mouse position"); }
                    
                    else if (X < 1 && Y < 1 )
                    { Console.WriteLine("Your output is ({0},{1})", S, Y); }
                    else if (X >= 0)
                    { Console.WriteLine("Your output is ({0},{1})", W, Y); }
                    break;
                default:
                    Console.WriteLine("Invaild Mode");
                    break;
            }
            Console.ReadLine();

        }
    }
}
