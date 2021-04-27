using System;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {

            static bool IsValidSequence(string halfDNASequence)
            {
                foreach (char nucleotide in halfDNASequence)
                {
                    if (!"ATCG".Contains(nucleotide))
                    {
                        return false;
                    }
                }
                return true;
            }

            static void Main(string[] args)
            {
                bool PlayAgain = false;
                while (true)
                {
                    Console.Write("Please Input your HalfDNASequence : ");
                    string Input = Console.ReadLine();

                    {
                        if (IsValidSequence(Input) == true)
                        {
                            Console.WriteLine("Current half DNA Sequence : " + Input);

                            while (true)
                            {
                                Console.Write("Do you want to replicate it ? (Y/N) : ");
                                string ans = Console.ReadLine();

                                if (ans == "Y")
                                {
                                    Console.WriteLine("Current half DNA Sequence : " + ReplicateSeqeunce(Input));
                                    break;
                                }
                                else if (ans == "N")
                                {

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please Input Y or N.");
                                }
                            }
                        }

                        else
                        {
                            Console.WriteLine("That half DNA sequence is invalid.");
                        }

                        while (true)
                        {
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            string an = Console.ReadLine();
                            if (an == "Y")
                            {
                                break;
                            }
                            else if (an == "N")
                            {
                                PlayAgain = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Input Y or N.");
                            }

                        }
                        if (PlayAgain == true)
                        {
                            break;
                        }
                    }

                }

            }


            //สังเคราะห์ DNA
            static string ReplicateSeqeunce(string halfDNASequence)
            {
                string result = "";
                foreach (char nucleotide in halfDNASequence)
                {
                    result += "TAGC"["ATCG".IndexOf(nucleotide)];
                }
                return result;
            }
        }
    }
}
