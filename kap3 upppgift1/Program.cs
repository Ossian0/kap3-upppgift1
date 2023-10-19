using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int svar = int.Parse(Console.ReadLine());

            switch (svar)
            {
                case 16:
                    Console.WriteLine("du får vara med i tävlingen.");
                    break;

                case 17:
                    Console.WriteLine("du får vara med i tävlingen.");
                    break;

                case 18:
                    Console.WriteLine("du får vara med i tävlingen.");
                    break;

                case 19:
                    Console.WriteLine("du får vara med i tävlingen.");
                    break;

                default:
                    Console.WriteLine("du får inte vara med i tävlingen.");
                    break;
            }


        }
    }
}