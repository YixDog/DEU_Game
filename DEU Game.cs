using System;

namespace Deu_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining the important variables.
            int PlayerCounter = 0;
            int A1Index = 0;
            int A2Index = 0;
            int A3Index = 0;
            int A1Color = -1;
            int A2Color = -1;
            int A3Color = -1;
            bool A1triplecolor = false;
            bool A2triplecolor = false;
            bool A3triplecolor = false;
            bool gameover = false;
            bool repeatscore = true;
            bool draw = false;            
            bool LetterAssign = false;
            int Player1Score = 120;
            int Player2Score = 120;
            string[] Letters = { "D", "E", "U" };
            Random random = new Random();
            //Defining the highscore arrays.
            string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan","" };
            int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };
            //Defining the main arrays for the game.
            string[] A1 = new string[15];
            string[] A2 = new string[15];
            string[] A3 = new string[15];           
                     
                while(!gameover) {
                //Assign the random letters to the arrays.
                while (!LetterAssign)
                {
                    string randomletter = Letters[random.Next(0, 3)];
                    if (randomletter == "D")
                    {
                        if (A1Index < 15)
                        {
                            A1[A1Index] = Letters[random.Next(0, 3)];
                            A1Index++;
                            LetterAssign = true;
                        }
                    }


                    else if (randomletter == "E")
                    {

                        if (A2Index < 15)
                        {
                            A2[A2Index] = Letters[random.Next(0, 3)];
                            A2Index++;
                            LetterAssign= true;
                        }
                    }
                    else
                    {

                        if (A3Index < 15)
                        {
                            A3[A3Index] = Letters[random.Next(0, 3)];
                            A3Index++;
                            LetterAssign = true;
                        }
                    }
                }
                LetterAssign = false;
                //Checking the numbers in the arrays, also determining the which letter should painted.
                for (int k = 0; k < 15; k++)
                {
                    if (A1[k] == "D" && A2[k] == "E" && A3[k] == "U")
                    {
                        gameover = true;
                        A1Color = k;
                        A2Color = k;
                        A3Color = k;
                    }
                    if (A1[k] == "U" && A2[k] == "E" && A3[k] == "D")
                    {
                        gameover = true;
                        A1Color = k;
                        A2Color = k;
                        A3Color = k;
                    }
                    for (int m = 0; m < 13; m++)
                    {
                        if (A1[m] == "U" && A1[m + 1] == "E" && A1[m + 2] == "D")
                        {

                            gameover = true;
                            A1Color = m;
                            A1triplecolor = true;

                        }
                        if (A1[m] == "D" && A1[m + 1] == "E" && A1[m + 2] == "U")
                        {

                            gameover = true;
                            A1Color = m;
                            A1triplecolor = true;

                        }
                        if (A2[m] == "D" && A2[m + 1] == "E" && A2[m + 2] == "U")
                        {

                            gameover = true;
                            A2Color = m;
                            A2triplecolor = true;
                        }
                        if (A2[m] == "U" && A2[m + 1] == "E" && A2[m + 2] == "D")
                        {

                            gameover = true;
                            A2Color = m;
                            A2triplecolor = true;

                        }
                        if (A3[m] == "D" && A3[m + 1] == "E" && A3[m + 2] == "U")
                        {

                            gameover = true;
                            A3Color = m;
                            A3triplecolor = true;

                        }
                        if (A3[m] == "U" && A3[m + 1] == "E" && A3[m + 2] == "D")
                        {

                            gameover = true;
                            A3Color = m;                           
                            A3triplecolor = true;

                        }
                        if (A1[m] == "D" && A2[m + 1] == "E" && A3[m + 2] == "U")
                        {

                            gameover = true;
                            A1Color = m;
                            A2Color = m + 1;
                            A3Color = m + 2;

                        }
                        if (A1[m] == "U" && A2[m + 1] == "E" && A3[m + 2] == "D")
                        {

                            gameover = true;
                            A1Color = m;
                            A2Color = m + 1;
                            A3Color = m + 2;

                        }
                        if (A3[m] == "D" && A2[m + 1] == "E" && A1[m + 2] == "U")
                        {

                            gameover = true;
                            A3Color = m;
                            A2Color = m + 1;
                            A1Color = m + 2;

                        }
                        if (A3[m] == "U" && A2[m + 1] == "E" && A1[m + 2] == "D")
                        {

                            gameover = true;
                            A3Color = m;
                            A2Color = m + 1;
                            A1Color = m + 2;

                        }
                    }  
                }
                //Player's point decreasing.
                if (PlayerCounter % 2 == 0)
                {
                    Player1Score -= 5;
                    Console.WriteLine("Player1:         P1-" + Player1Score + " P2-" + Player2Score);
                }
                else
                {
                    Player2Score -= 5;
                    Console.WriteLine("Player2:         P1-" + Player1Score + " P2-" + Player2Score);
                }
                PlayerCounter++;
                //Printing A1 Array.
                Console.Write("A1: ");
                for (int a = 0; a < 15; a++)
                {
                    if (a == A1Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if(A1triplecolor){
                        if (a == A1Color)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if(a==A1Color+1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (a == A1Color + 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(A1[a] + " ");
                }
                Console.Write("\n");
                //Printing A2 Array.
                Console.Write("A2: ");
                for (int a = 0; a < 15; a++)
                {
                    if (a == A2Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (A2triplecolor)
                    {
                        if (a == A2Color)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (a == A2Color + 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (a == A2Color + 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(A2[a] + " ");
                }
                Console.Write("\n");
                //Printing A3 Array.
                Console.Write("A3: ");

                for (int a = 0; a < 15; a++)
                {
                    if (a == A3Color)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (A3triplecolor)
                    {
                        if (a == A3Color)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (a == A3Color + 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (a == A3Color + 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(A3[a] + " ");
                }
                //Checking is it draw.
                Console.Write("\n\n");
                if (A1Index == 15 && A2Index == 15 && A3Index == 15)
                {
                    draw = true;

                }
                //Checking is the game over if it is, checking PlayerCounter variable to which player won, and printing the highscore board.
                if (gameover)
                    {
                        if ((PlayerCounter - 1) % 2 == 0)
                        {

                            int[] newscores = new int[13];
                            newscores[0] = Player1Score;
                            for (int i = 1; i < 13; i++)
                            {
                                newscores[i] = scores[i - 1];
                            }
                            Array.Sort(newscores);
                            Array.Reverse(newscores);
                            for (int i = 0; i < 13; i++)
                            {
                                if (newscores[i] < Player1Score && repeatscore)
                                {
                                    if (i == 0)
                                    {

                                        for (int l = 0; l < 12; l++)
                                        {
                                            names[12 - l] = names[11 - l];

                                        }
                                        names[i] = "Player1";
                                        repeatscore = false;
                                    }
                                    else
                                    {
                                        for (int l = 0; l < 13 - i; l++)
                                        {
                                            names[12 - l] = names[11 - l];
                                        }
                                        names[i - 1] = "Player1";
                                        repeatscore = false;

                                    }
                                }
                                else if (newscores[i] > Player1Score && repeatscore)
                                {
                                    names[12] = "Player1";
                                }
                            }
                            Console.WriteLine("Player 1 won\n");
                            Console.WriteLine("Name      " + "Score");
                            for (int m = 0; m < 13; m++)
                            {

                                Console.Write(names[m]);
                                for (int i = 0; i < 10 - names[m].Length; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.WriteLine(newscores[m]);

                            }
                        }
                        else
                        {

                            int[] newscores = new int[13];
                            newscores[0] = Player2Score;
                            for (int i = 1; i < 13; i++)
                            {
                                newscores[i] = scores[i - 1];
                            }
                            Array.Sort(newscores);
                            Array.Reverse(newscores);
                            for (int i = 0; i < 13; i++)
                            {
                                if (newscores[i] < Player2Score && repeatscore)
                                {
                                    if (i == 0)
                                    {

                                        for (int l = 0; l < 12; l++)
                                        {
                                            names[12 - l] = names[11 - l];

                                        }
                                        names[i] = "Player2";
                                        repeatscore = false;
                                    }
                                    else
                                    {
                                        for (int l = 0; l < 13 - i; l++)
                                        {
                                            names[12 - l] = names[11 - l];
                                        }
                                        names[i - 1] = "Player2";
                                        repeatscore = false;

                                    }
                                }
                                else if (newscores[i] > Player2Score && repeatscore)
                                {
                                    names[12] = "Player2";
                                }
                            }
                            Console.WriteLine("Player 2 won\n");
                            Console.WriteLine("Name      " + "Score");
                            for (int m = 0; m < 13; m++)
                            {

                                Console.Write(names[m]);
                                for (int i = 0; i < 10 - names[m].Length; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.WriteLine(newscores[m]);

                            }

                        }
                        break;
                    }
                //If the game is draw, printing "The game is draw" and highscore without player name.
                else if (draw)
                    {
                        Console.WriteLine("The game is draw\n");
                        Console.WriteLine("Name      " + "Score");
                        for (int m = 0; m < 12; m++)
                        {

                            Console.Write(names[m]);
                            for (int i = 0; i < 10 - names[m].Length; i++)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine(scores[m]);
                        }
                    }                    
                }
            //This is for not to close program automatically.
            Console.Read();
        }
    }
}