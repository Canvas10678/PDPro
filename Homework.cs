using System;

namespace HOMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, Unit, Tens, Hundred, Thousand, Ten_Thousand, Hundred_Thousand;
            string Group;
            Console.Write("Input your Password : ");
            NUM = int.Parse(Console.ReadLine());
            Console.Write("Input your Group : ");
            Group = Console.ReadLine();
            bool A;

            Hundred_Thousand = NUM / 100000;
            Ten_Thousand = NUM / 10000 - (Hundred_Thousand * 10);
            Thousand = NUM / 1000 - (Hundred_Thousand * 100) - (Ten_Thousand * 10);
            Hundred = NUM / 100 - (Hundred_Thousand * 1000) - (Ten_Thousand * 100) - (Thousand * 10);
            Tens = NUM / 10 - (Hundred_Thousand * 10000) - (Ten_Thousand * 1000) - (Thousand * 100) - (Hundred * 10);
            Unit = NUM / 1 - (Hundred_Thousand * 100000) - (Ten_Thousand * 10000) - (Thousand * 1000) - (Hundred * 100) - (Tens * 10);

            if (Group == "CIA")
            {
                A = ((Unit % 3 == 0)) && ((Tens == 0) || (Tens == 2) || (Tens == 4) || (Tens == 6) || (Tens == 7) || (Tens == 8) || (Tens == 9)) && ((Thousand >= 6) && (Thousand != 8));
                Console.WriteLine(A);
            }
            else if (Group == "FBI")
            {
                A = ((Hundred_Thousand >= 4) && (Hundred_Thousand <= 7)) && ((Hundred % 2 == 0) && (Hundred != 6)) && ((Ten_Thousand == 1) || (Ten_Thousand == 3) || (Ten_Thousand == 5) || (Ten_Thousand == 7) || (Ten_Thousand == 9));
                Console.WriteLine(A);
            }
            else if (Group == "NSA")
            {
                A = ((Unit == 1) || (Unit == 2) || (Unit == 3) || (Unit == 5) || (Unit == 6)) && ((Hundred % 3 == 0) && (Hundred % 2 != 0)) && ((Unit == 7) || (Tens == 7) || (Hundred == 7) || (Thousand == 7) || (Ten_Thousand == 7) || (Hundred_Thousand == 7));
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
