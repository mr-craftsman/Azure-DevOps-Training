using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06hangmanGame
{
    class Program
    {
        static string[] words;
        static string selectedWord;
        static char[] guessedLetters;
        static int attemptsLeft;
        static char[] hangmanParts = { 'O', '|', '/', '\\', '/', '\\' };

        static void Main()
        {
            LoadWordsFromFile("C:\\Users\\radad\\Desktop\\Projects\\AzureTraining\\Extra projects\\EX06hangmanGame\\words.txt");

            selectedWord = SelectRandomWord().ToUpper();

            guessedLetters = new char[selectedWord.Length];
            attemptsLeft = 6;

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Guess the word by entering one letter at a time.");
            Console.WriteLine("You have 6 attempts to guess the word correctly.");

            while (true)
            {
                Console.WriteLine();
                DisplayWord();
                Console.WriteLine();

                Console.Write("Enter a letter: ");
                char letter = Console.ReadLine().ToUpper()[0];

                if (!char.IsLetter(letter))
                {
                    Console.WriteLine("Invalid input. Please enter a letter.");
                    continue;
                }

                if (IsLetterGuessed(letter))
                {
                    Console.WriteLine("You have already guessed that letter. Please try a different one.");
                    continue;
                }

                if (IsLetterInWord(letter))
                {
                    Console.WriteLine("Correct guess!");
                    UpdateGuessedLetters(letter);

                    if (IsWordGuessed())
                    {
                        Console.WriteLine();
                        DisplayWord();
                        Console.WriteLine("Congratulations! You guessed the word correctly.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect guess!");
                    attemptsLeft--;

                    if (attemptsLeft == 0)
                    {
                        Console.WriteLine("Sorry, you ran out of attempts. The word was: " + selectedWord);
                        break;
                    }
                }

                Console.WriteLine("Attempts left: " + attemptsLeft);
                Console.WriteLine("Hangman: " + GetHangmanProgress());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void LoadWordsFromFile(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                words = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The words file could not be found.");
                Console.WriteLine("Please make sure the file exists and try again.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static string SelectRandomWord()
        {
            Random random = new Random();
            int index = random.Next(words.Length);
            return words[index];
        }

        static void DisplayWord()
        {
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (guessedLetters[i] == '\0')
                    Console.Write("_ ");
                else
                    Console.Write(guessedLetters[i] + " ");
            }
        }

        static bool IsLetterGuessed(char letter)
        {
            return guessedLetters.Contains(letter);
        }

        static bool IsLetterInWord(char letter)
        {
            return selectedWord.Contains(letter);
        }

        static void UpdateGuessedLetters(char letter)
        {
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == letter)
                    guessedLetters[i] = letter;
            }
        }

        static bool IsWordGuessed()
        {
            return !guessedLetters.Contains('\0');
        }

        static string GetHangmanProgress()
        {
            int hangmanIndex = hangmanParts.Length - attemptsLeft;
            string progress = "";

            for (int i = 0; i <= hangmanIndex; i++)
            {
                progress += hangmanParts[i] + " ";
            }

            return progress;
        }
    }
}
