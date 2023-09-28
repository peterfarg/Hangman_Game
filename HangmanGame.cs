using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class HangmanGame
{
    private readonly List<string> wordList = new List<string>
    {
        // List of words here
    };

    private string chosenWord;
    private int wordLength;
    private bool endOfGame;
    private int lives;

    private readonly string[] stages = new string[]
    {
        // Hangman stages here
    };

    private readonly string logo = @"
 _                                             
| |                                            
| |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
| '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
|_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/
";

    public void PlayGame()
    {
        Random random = new Random();
        chosenWord = wordList[random.Next(0, wordList.Count)];
        wordLength = chosenWord.Length;
        endOfGame = false;
        lives = 6;
        List<char> display = Enumerable.Repeat('_', wordLength).ToList();

        Console.WriteLine(logo);

        while (!endOfGame)
        {
            char guess = GetGuess().ToLower()[0];
            Console.Clear();

            if (display.Contains(guess))
            {
                Console.WriteLine($"You've already guessed {guess}");
            }
            else
            {
                for (int position = 0; position < wordLength; position++)
                {
                    char letter = chosenWord[position];
                    if (letter == guess)
                    {
                        display[position] = letter;
                    }
                }

                if (!chosenWord.Contains(guess))
                {
                    Console.WriteLine($"You guessed {guess}, that's not in the word. You lose a life.");
                    lives--;

                    if (lives == 0)
                    {
                        endOfGame = true;
                        Console.WriteLine("You lose.");
                    }
                }

                Console.WriteLine(string.Join(' ', display));

                if (!display.Contains('_'))
                {
                    endOfGame = true;
                    Console.WriteLine("You win.");
                }

                Console.WriteLine(stages[lives]);
            }
        }
    }

    private string GetGuess()
    {
        Console.Write("Guess a letter: ");
        return Console.ReadLine();
    }
}
