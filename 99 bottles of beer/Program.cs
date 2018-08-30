using System;

namespace _99_bottles_of_beer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that prints out the lyrics to the song “99 Bottles of Beer on the Wall”

            Console.WriteLine("Sing along!");

            for (int i = 99; i >= 0; i--)
            {
                int beerLeft = i - 1;
                Console.WriteLine($"{i} bottles of beer on the wall. {i} bottles of beer. You take 1 down, " +
                    $"pass it around, {beerLeft} bottles of beer on the wall.");

                 
                if (beerLeft == 0) break;

            }

            Console.ReadLine();









        }
    }
}
