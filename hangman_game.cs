using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.cs.hange_man
{
    class HangManGame
    {   // checking for word 
        static bool IsWord(string secreword, List<string> letterGuessed)//return true or false
        {

            bool word = false;
            // loop through secretword
            for (int i = 0; i < secreword.Length; i++)
            {
                // initialize c with the index of secretword[i]
                string c = Convert.ToString(secreword[i]);
                // check if c is in list of letters Guess
                if (letterGuessed.Contains(c))
                {
                    word = true;
                }
                /*if c is not in the letters guessed then we dont have the
                 * we dont have the full word*/
                else
                {
                    // change the value of word to false and return false
                    return word = false;

                }

            }
            return word;
        }

        // check for single letter 
        static string Isletter(string secretword, List<string> letterGuessed)
        {
            // set guessedword as empty string
            string correctletters = "";
            // loop through secret word
            for (int i = 0; i < secretword.Length; i++)
            {
                /* initialize c with the value of index i
                 * mean when i = 0
                 * c = secretword[0] is the first index of secretword
                  c = secretword[1] is the second index of secretword and so on */
                string c = Convert.ToString(secretword[i]);

                // if c is in list of lettersGuessed 
                if (letterGuessed.Contains(c))
                {
                    // add c to correct letters
                    correctletters += c;
                }
                else
                {
                    // else print (__) to show that the letter is not in the secretword
                    correctletters += "_ ";
                }

            }
            // after looping return all the correct letters found
            return correctletters;

        }

        // The alphabet to use
        
        /* random strings
        static string RandomWord(string secretword) 
        {
           Random rnd = new Random();

        }*/

                static void hangmanstart()
                {
                    Console.WriteLine("888                                                                  ");
                    Console.WriteLine("888                                                                  ");
                    Console.WriteLine("888                                                                  ");
                    Console.WriteLine("88888b.    8888b. 88888b.   .d88b.  88888b.d88b.   8888b.  88888b.   ");
                    Console.WriteLine("888 '88b     '88b 888 '88b d88P'88b 888 '888 '88b    '88b8 888 '88b  ");
                    Console.WriteLine("888  888 .d888888 888  888 888  888 888  888  888 .d888888 888  888  ");
                    Console.WriteLine("888  888 888  888 888  888 Y88b 888 888  888  888 888  888 888  888  ");
                    Console.WriteLine("888  888 'Y888888 888  888  'Y88888 888  888  888 'Y888888 888  888  ");
                    Console.WriteLine("                                888                                  ");
                    Console.WriteLine("                           Y8b d88P                                  ");
                    Console.WriteLine("                            'Y88P'                                   ");

                    Console.WriteLine(" _______.._____            ");
                    Console.WriteLine("| .__________))______|           ");
                    Console.WriteLine("| | / /      ||                  ");
                    Console.WriteLine("| |/ /       ||                  ");
                    Console.WriteLine("| | /        ||.-''.             ");
                    Console.WriteLine("| |/         |/  _  |            ");
                    Console.WriteLine("| |          ||  `/,|            ");
                    Console.WriteLine("| |          (\\`_.'             ");
                    Console.WriteLine("| |         .-`--'.              ");
                    Console.WriteLine("| |        /Y . . Y|             ");
                    Console.WriteLine("| |       // |   | \\            ");
                    Console.WriteLine("| |      //  | . |  \\     		");
                    Console.WriteLine("| |     ')   |   |   (`			");
                    Console.WriteLine("| |          ||'||				");
                    Console.WriteLine("| |          || ||   			");
                    Console.WriteLine("| |          || ||				");
                    Console.WriteLine("| |          || ||				");
                    Console.WriteLine("| |         / | | |				");
                    Console.WriteLine("|-|-------|_`-' `-' |-|-|		");
                    Console.WriteLine("|-|------ ||      --|-|	       	");
                    Console.WriteLine("| |       ||        | |		    ");
                    Console.WriteLine("| |       ||        | |	        ");
                    Console.WriteLine("| |--------`'-------| |   		");


                }
                static void Main()
                {
                    Console.Title = ("HangMan");
                    hangmanstart();

                    // secretWord
                    //string secretword2 = "foreground";
                    // string[] secretword1 = System.IO.File.ReadAllLines(@"D:\texthangman\texthangman.txt");
                    // int LengthOfArray = secretword1.Length;
                    // Random rnd = new Random();
                    // int random = rnd.Next(0, 2);
                    // string[] letters = secretword1[random].ToCharArray();
                    //string secretword0;
                    //secretword = secretword1[1];
                    //secretword0 = secretword1[random];
                    List<string> letterGuessed = new List<string>();


                    int live = 6;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Welcome to Hangman Game");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Input a word player A :");
                    string secretword = "";
                    while (true)
                    {
                        var key = System.Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                            break;
                        secretword += key.KeyChar;
                    }

                    //string inputletter = Console.ReadLine();
                    Console.WriteLine("Guess for a {0} letter Word ", secretword.Length);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You have {0} live", live);
                    Isletter(secretword, letterGuessed);// check letter
                                                        // while live is greater than 0
                    while (live > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input = Console.ReadLine();

                        // if letterGuessed contains input



                        if (letterGuessed.Contains(input))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Entered letter [{0}] already", input);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You have already tried this letter.");
                            //GetAlphabet(input);
                            continue;
                        }


                        // if word found
                        letterGuessed.Add(input);
                        if (IsWord(secretword, letterGuessed))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(secretword);
                            Console.WriteLine("Good work.");
                            Console.WriteLine("Do you to play again? input 1 play or input 0 Quit");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                Main();
                            }
                            else { break; }
                        }
                        // if a letter in word found
                        else if (secretword.Contains(input))
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("That's correct.");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("You have {0} live", live);
                            if (live == 6)
                            {
                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 5)

                            {
                                Console.WriteLine("  _________     ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |           ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");
                            }
                            else if (live == 4)

                            {
                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");
                            }
                            else if (live == 3)

                            {

                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|    ");
                                Console.WriteLine("  |       |     ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 2)

                            {

                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|__      ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 1)

                            {

                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|__   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |      | |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 0)

                            {

                                Console.WriteLine("  _____      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|__   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |      | |   ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else
                            {
                                //
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            string letters = Isletter(secretword, letterGuessed);
                            Console.Write(letters);

                        }
                        // when a wrong code is entered
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No,that's wrong");
                            live -= 1;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("You have {0} live", live);
                            if (live == 6)
                            {
                                Console.WriteLine("  _________    ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 5)

                            {
                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |           ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");
                            }
                            else if (live == 4)

                            {
                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");
                            }
                            else if (live == 3)

                            {

                                Console.WriteLine("  _________      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 2)

                            {

                                Console.WriteLine("  _____      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|__   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 1)

                            {

                                Console.WriteLine("  _____      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|__   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |      |     ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else if (live == 0)

                            {

                                Console.WriteLine("  _____      ");
                                Console.WriteLine("  |/      |    ");
                                Console.WriteLine("  |      (_)   ");
                                Console.WriteLine("  |     __|__   ");
                                Console.WriteLine("  |       |    ");
                                Console.WriteLine("  |      | |   ");
                                Console.WriteLine("  |            ");
                                Console.WriteLine("  |__         ");

                            }
                            else
                            {
                                //
                            }
                        }
                        Console.WriteLine();
                        // print secret word 
                        if (live == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Game over \nMy secret Word is [ {0} ]", secretword);
                            Console.WriteLine("Do you to play again? input 1 play or input 0 Quit");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                Main();
                            }
                            else { break; }
                        }

                    }
                    Console.WriteLine("press any key to Exit");
                    Console.ReadKey();




                }
            }
        } 
