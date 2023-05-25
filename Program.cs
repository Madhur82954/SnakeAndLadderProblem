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

            while (currpos < Finalpos)
            {

                int Dieroll=random.Next(1, 6);
                Console.WriteLine("Player roll a die get = " + Dieroll);

                //UC3-Check For Option
                int option = random.Next(0, 3);
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("No Play. The Player Stays in Same Position");
                            break;

                        case 1:
                            Console.WriteLine("Ladder. The Player Moves Ahead By " + Dieroll + " Positions");
                            currpos += Dieroll;
                            break;

                        case 2:
                            Console.WriteLine("Snake . The Player Moves Behind By " + Dieroll + " Positions");
                            currpos -= Dieroll;

                            if (currpos < 0)
                            {
                                currpos = 0;
                            }
                            break;
                    }
                Console.WriteLine("Current Position = " + currpos);

            }
            Console.WriteLine("Congratulations! Player Has reached to the winning position");
            
        }
    }
}
