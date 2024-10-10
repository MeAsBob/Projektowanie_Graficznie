using System;
using System.Diagnostics;


namespace GraafoczmaWersa
{

    internal static class Program
    {


        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //    Console.WriteLine($"Czas wykonania funkcji: {stopwatch.Elapsed.TotalMilliseconds / 1000} Sekund" + "\t");//Pokazywanie Czasu 

            //    Console.WriteLine("Macierz A");
            //    for (int i = 0; i < Size; i++)
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            Console.Write($"{MatrixA[i, j]:F2} " + "\t");//Wyœwietlanie Macierzy A
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("Macierz L");
            //    for (int i = 0; i < Size; i++)
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            Console.Write($"{MatrixL[i, j]:F2} " + "\t");//Wyœwietlanie Macierzy L
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("Macierz U");
            //    for (int i = 0; i < Size; i++)
            //    {
            //        for (int j = 0; j < Size; j++)
            //        {
            //            Console.Write($"{MatrixU[i, j]:F2} " + "\t");//Wyœwietlanie Macierzy U
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}