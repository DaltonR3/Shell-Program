using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CupsGame
{
    class Program
    {
        static int timesToSwap = 5;
        static int numSwapped = 0;

        static void Main(string[] args)
        {
            Controller C = new Controller();
            C.shuffle(timesToSwap);
            Console.WriteLine("Which cup is the ball under?");
            int guess = int.Parse(Console.ReadLine());
            switch (C.guess(guess))
            {
                case null:
                    {
                        Console.WriteLine("You have guessed incorrectly!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You have guessed correctly!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }

}
