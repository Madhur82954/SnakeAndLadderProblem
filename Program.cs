using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1-start and end Position
            int currpos = 0;
            int Finalpos = 100;
            Console.WriteLine("Start pos = " + currpos);

            //UC2- RollDie
            Random random = new Random();
            int Dieroll=random.Next(1, 6);
            Console.WriteLine("Player roll a die get = " + Dieroll);
        }
    }
}
