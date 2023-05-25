using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1-start and end Position
            int Finalpos = 100;
            Console.WriteLine("Start pos = 0" );
            int[] playerposition = new int[2];
            int currentplayer = 0;
            int DiceRoll = 0;

            //UC2- RollDie
            Random random = new Random();

            while (playerposition[currentplayer] < Finalpos)
            {

                int Dieroll=random.Next(1, 6);
                Console.WriteLine("Player" + (currentplayer + 1)  + "roll a die get = " + Dieroll);

                //UC3-Check For Option
                int option = random.Next(0, 3);
                    switch (option)
                    {
                        case 0://No play
                            Console.WriteLine("No Play. The Player Stays in Same Position");
                            break;

                        case 1: // Ladder
                            Console.WriteLine("Ladder. The Player" + (currentplayer + 1) + "Moves Ahead By " + Dieroll + " Positions");

                            if(playerposition[currentplayer] + Dieroll <= Finalpos)
                                playerposition[currentplayer] += Dieroll;
                            break;

                        case 2: //Snake
                            Console.WriteLine("Snake . The Player" + (currentplayer + 1) + "Moves Behind By " + Dieroll + " Positions");
                            playerposition[currentplayer] -= Dieroll;

                            if (playerposition[currentplayer] < 0)
                            {
                                playerposition[currentplayer] = 0; //Restart from 0 if position below 0
                            }
                            break;
                    }
                    DiceRoll++;
                    Console.WriteLine("Player" + (currentplayer + 1) +"Current Position = " + playerposition[currentplayer]);

                if (option != 1)
                {
                    currentplayer = (currentplayer + 1) % 2;
                }

            }
            Console.WriteLine("Congratulations! Player Has reached to the winning position");
            Console.WriteLine("Number of DiceRolls = " + DiceRoll);
            Console.WriteLine("Player" + (currentplayer + 1) + "Wins the game");
        }
    }
}
