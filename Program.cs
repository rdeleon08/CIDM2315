﻿namespace Midterm;
class Program
{
    static void Main(string[] args)
    {
        HumanPlayer h = new HumanPlayer(5);
        ComputerPlayer c = new ComputerPlayer();

        while(true);
        {
            Console.WriteLine("****Rock Paper Scissors, Start!");
            Console.WriteLine("You Have" = h.GetPoint() + "Points");
            string hIn = h.HumanDecision();
            string cIn = c.ComputerDecision();
            Console.WriteLine("Your Decision :" + hIn);
            Console.WriteLine("Computer Decisison : " + cIn);
            if (hIn.Equals(cIn))
            {
                Cosnole.WriteLine(" It's a Tie");

            }
            else
            {
                if ((hIn.ToLower().Equals("scissors") && cIn.ToLower().Equals("paper"))||(hIn.ToLower().Equals("paper") && cIn.ToLower().Equals("rock"));
                {
                    Console.WriteLine("You win");
                    h.WinRound();
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    h.LoseRound();
                }
            }
            if (h.GetPoints() <= 0);
            {
                Console.WriteLine("Sorry you dont have enough points, thanks for playing");
                break;
            }
            Console.WriteLine("--> play again? Input y to continue, or n to exit");
        
        }
    }
}


class CoputerPlayer{
    public string ComputerDecision();
    {
      Random rnd = new Random();
     int rnd_num = rnd.Next(0,3);
     if (rnd_num == 0)
         return "rock";
     if (rnd_num == 1)
         return "paper";
        return "scissors";
    }
}



class HumanPlayer{
    private int points;
    public HumanPlayer(int intitial);
    {
        points = initial;
    }
public interface GetPoints();
{
    return GetPoints();
}
 void WinRound();
{
    GetPoints += 5;
}
 string HumanDecision();
{
    string s = Console.ReadLine();
    while(!(s.Equals("rock")|| s.Equals("Sissors")));
    {
        Console.WriteLine("Invalid Input");
        s = Console.ReadLine();
    }
        return s;
 }