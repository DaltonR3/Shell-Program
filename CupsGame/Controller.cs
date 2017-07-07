using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CupsGame
{
    class Controller
    {
        private static Random r;
        private static Cups[] cupsArray;
        private int ballStart;

        public Controller()
        {
            cupsArray = new Cups[3];
            Cups A = new Cups("A"), B = new Cups("B"), C = new Cups("C");
            cupsArray[0] = A;
            cupsArray[1] = B;
            cupsArray[2] = C;
            r = new Random();
            Ball ball = new Ball();
            ballStart = r.Next(0, 3);
            cupsArray[ballStart].setBall(ball);
            Console.WriteLine("Welcome to the Cups game! The ball is currently under cup #{0}.\n", ballStart + 1);
        }
        public void shuffle(int numShuffles)
        {
            for (int x=0; x <= numShuffles; x++)
            {
                int first = r.Next(0, 3);
                int second = r.Next(0, 3);
                while (first == second)
                    second = r.Next(0, 3);
                swap(first, second);
                Console.WriteLine("Cup {0} and {1} have been swapped!\n", first + 1, second + 1);
            }
        }
        private void swap(int first, int second)
        {
            Cups c = cupsArray[first];
            cupsArray[first] = cupsArray[second];
            cupsArray[second] = c;
        }

        public Ball guess(int choice)
        {
            return cupsArray[choice - 1].getBall();
        }
    }
}
