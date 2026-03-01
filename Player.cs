/*
* CS2 – Lab 6.1
* Author: Your Name
* Date: 03/01/2026
* Description: Handles player name and input for Rock Paper Scissors
*/

using System;

/// <summary>
/// Represents a human player.
/// </summary>
public class Player
{
    public string Name { get; set; }

    /// <summary>
    /// Prompts the player for a choice.
    /// </summary>
    /// <returns>Rock, Paper, or Scissors</returns>
    public string GetChoice()
    {
        Console.Write($"{Name}, enter Rock, Paper, or Scissors: ");
        return Console.ReadLine();
    }
}