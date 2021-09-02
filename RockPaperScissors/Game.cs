using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {


        int randomNumber;

        Random random = new Random();

        int maxRounds = 10;





        string userInput, totalRounds, computerInput;
        int rounds;


        public void PlayTheGame()
        {

            Console.WriteLine("How many rounds do you want to play? You can play up to 10 rounds.");
            totalRounds = Console.ReadLine();
            rounds = int.Parse(totalRounds);
            rounds = 1;
            Here:
            Console.WriteLine("Do you pick Rock, Paper, or Scissors? Please type into the box below: ");
            userInput = Console.ReadLine();
            
            randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {


                case 1:

                    computerInput = "Rock";
                    Console.WriteLine("The computer picked Rock.");
                    if (userInput == "Rock")
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    else if (userInput == "Paper")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose! Better luck next time!");
                    }
                    rounds++;
                    if (rounds > maxRounds)
                    {
                        EndGame();
                    }
                    else
                    {
                        goto Here;
                    }
                    break;

                case 2:
                    computerInput = "Paper";
                    Console.WriteLine("The computer picked Paper");
                    if (userInput == "Rock")
                    {
                        Console.WriteLine("Sorry! You lost!");
                    }
                    else if (userInput == "Scissors")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    rounds++;
                    if (rounds > maxRounds)
                    {
                        EndGame();
                    }
                    else
                    {
                        goto Here;
                    }

                    break;
                case 3:
                    computerInput = "Scissors";
                    Console.WriteLine("The computer picked Scissors");
                    if (userInput == "Paper")
                    {
                        Console.WriteLine("Sorry! You lost!");
                    }
                    else if (userInput == "Rock")
                    {
                        Console.WriteLine("You win! You crushed those scissors!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    rounds++;
                    if (rounds > maxRounds)
                    {
                        EndGame();
                    }
                    else
                    {
                        goto Here;
                    }

                    break;
                default:

                    Console.WriteLine("Whoops! That's not Rock/Paper/Scissors!");
                    PlayTheGame();

                    break;


            }

        }
        public void EndGame()
        {
            if (rounds > maxRounds)
            {
                Console.WriteLine("Would you like to play again?");
                string userInput = Console.ReadLine();
                if (userInput == "Yes")
                {
                    PlayTheGame();
                }
                else
                {
                    Console.WriteLine( "Thanks for playing!");
                }

            }
            
           

        }
    }
}

