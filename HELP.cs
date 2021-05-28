using System;
using System.IO;

namespace ConsoleApp1
    {
    class Program
    {
        //รับค่าผ่าน
        static void Main(string[] args)
        {
            string filee, convole, result;
            Console.Write("Input your address image : ");
            filee = Console.ReadLine();
            double[,] imageDataArray = ReadImageDataFromFile(filee);
            Console.Write("Input your address Convole : ");
            convole = Console.ReadLine();
            double[,] ConvolveArray = ReadImageDataFromFile(convole);

            Console.Write("Input your address result : ");
            result = Console.ReadLine();

            double[,] KeepMatum =  Matum(imageDataArray);
            double[,] resultarray = Convolve(KeepMatum, imageDataArray.GetLength(0), imageDataArray.GetLength(1), ConvolveArray);
            WriteImageDataToFile(result, resultarray);


        }

        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static double[,] Matum(double[,] ReadImageDataFromFile)
        {
            int width, hight;
            //กำหนดขนาด
            width = ReadImageDataFromFile.GetLength(0)+2; //7
            hight = ReadImageDataFromFile.GetLength(1)+2; //7
            double[,] A = new double[width, hight];
            //เติมค่า
            for (int i = 0; i < width ; i++)
            {

                for (int j = 0; j < hight ; j++)
                {
                    A[i, j] = ReadImageDataFromFile[(i + 4) % 5,( j + 4) % 5]; 
             
                }
                
            }
            return A;

        }


        static void WriteImageDataToFile(string imageDataFilePath,
                                         double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }



        static double[,] Convolve (double[,] Matum,int Column, int Row ,double[,] Convole)
        {
            double[,] Result = new double [Column,Row];
            for (int i = 0; i < Column; i++) 
            {
                for (int j = 0; j < Row; j++) 
                {
                    for (int c = 0; c < Convole.GetLength(0); c++) 
                    {
                        for (int r = 0; r < Convole.GetLength(1); r++) 
                        {
                            Result[i, j] +=  Matum[c + j, r + i] * Convole[c,r];
                        }
                    }
                }
            }
            return Result; 
        }


    }

}

    

