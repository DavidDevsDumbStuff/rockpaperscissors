using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/*
 * CS2 - Lab 6.1
 * Author: Dakota
 * Date: 02/23/2026
 * Description: This class is the computer player for rock paper scissors.
 */

public class ComputerPlayer
{
    // This method generates a random choice for the computer player.
    public string GetChoice()
    {
        Random rand = new Random();
        int choice = rand.Next(1, 4); // 1 = rock, 2 = paper, 3 = scissors
        switch (choice)
        {
            case 1:
                return "rock";
            case 2:
                return "paper";
            case 3:
                return "scissors";
            default:
                return "rock";
        }
    }
}
