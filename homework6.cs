using System;

namespace longgg
{
    class Program
    {
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }
        static void Main(string[] args)
        {
            double enummm = 0; 
           
            double Score = 0; int Num; double data = 0; int NumProb = 0;

            Console.WriteLine("Score: {0}, Difficulty: {1}", Score, (Difficulty)enummm);

            double pass = 0; 
            double start; double end; double result;
           
            while (true)
            {
                Console.Write("Input your Number to go Menu : ");
                Num = int.Parse(Console.ReadLine());
                if (Num == 0)
                {

                    Console.WriteLine("Return to play");
                    start = DateTimeOffset.Now.ToUnixTimeSeconds();

                    if (Num == 0)
                    {
                        NumProb = 3;
                    }
                    else if (Num == 1)
                    {
                        NumProb = 5;
                    }
                    else if (Num == 2)
                    {
                        NumProb = 7;
                    }


                    Problem[] Problems = GenerateRandomProblems(NumProb);
                    for (int i = 0; i < NumProb; i++)
                    {
                        Console.Write(Problems[i].Message);
                        int ans = int.Parse(Console.ReadLine());
                        if (ans == Problems[i].Answer)
                        {
                            pass = pass + 1;
                        }
                    }
                    end = DateTimeOffset.Now.ToUnixTimeSeconds();
                    result = end - start;
                    Console.WriteLine("the time is : {0} second ", result);
                    double Qc = pass; double Qa = NumProb; double timeBefore = start;
                    double timeAfter = end;
                    double resulttime = timeAfter - timeBefore;
                    double d = data;
                    double S = (Qc / Qa) * (25 - Math.Pow(data, 2)) / Math.Max(resulttime, 25 - (Math.Pow(d, 2)) * Math.Pow((2 * d) + 1, 2));
                    Score = S;
                    Console.WriteLine("Score: {0}, Difficulty: {1}", Score, data);
                }
                else if (Num == 1)
                {
                    Console.WriteLine("Go to Setting.");
                    Console.Write("Input your Number to choose level : ");
                    Difficulty step;
                    data = int.Parse(Console.ReadLine());
                    if (data == 0)
                    {
                        step = Difficulty.Easy;

                    }
                    else if (data == 1)
                    {
                        step = Difficulty.Normal;

                    }
                    else if (data == 2)
                    {
                        step = Difficulty.Hard;

                    }
                    else
                    {
                        Console.WriteLine("Please input 0-2");
                        Console.WriteLine("Try again");
                    }
                    Console.WriteLine("Score: {0}, Difficulty: {1}", Score, data);
                }
                else if (Num == 2)
                {
                    Console.WriteLine("To Exit");
                }
                else
                {
                    Console.WriteLine("Please input 0-2");
                }






            }

        }
    }
}










        