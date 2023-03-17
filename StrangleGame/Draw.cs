using System;
namespace StrangleGame
{
        class Draw
        {
                public static void Image(int attemps, string hideWord){
                        Console.WriteLine("====================");
                        Console.WriteLine($"Intentos: {attemps}");
                        Console.WriteLine("====================");
                        switch (attemps)
                        {
                                case 6:
                                        Console.WriteLine(" ---------------------");
                                        for (int j = 0; j <= 15; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;

                                case 5:
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                 | -  -  |");
                                        Console.WriteLine(" |                 |   o   |");
                                        Console.WriteLine(" |                  -------");
                                        for (int j = 0; j <= 10; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;

                                case 4:
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                 | -  -  |");
                                        Console.WriteLine(" |                 |   o   |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                     |   ");
                                        for (int j = 0; j <= 5; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;

                                case 3:
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                 | -  -  |");
                                        Console.WriteLine(" |                 |   o   |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                   / |   ");
                                        Console.WriteLine(" |                 /   |   ");
                                        Console.WriteLine(" |                /    |   ");
                                        Console.WriteLine(" |                     |   ");
                                        for (int j = 0; j <= 5; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;

                                case 2:
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                 | -  -  |");
                                        Console.WriteLine(" |                 |   o   |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                   / | \\ ");
                                        Console.WriteLine(" |                  /  |   \\ ");
                                        Console.WriteLine(" |                 /   |     \\ ");
                                        Console.WriteLine(" |                     |   ");
                                        for (int j = 0; j <= 5; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;

                                case 1:
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                 | -  -  |");
                                        Console.WriteLine(" |                 |   o   |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                   / | \\ ");
                                        Console.WriteLine(" |                  /  |   \\ ");
                                        Console.WriteLine(" |                 /   |     \\ ");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                    /  ");
                                        Console.WriteLine(" |                   /      ");
                                        Console.WriteLine(" |                  /       ");
                                        for (int j = 0; j <= 2; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;

                                case 0:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("GAME OVER - La palabra oculta era {0}",hideWord);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                     |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                 | X  X  |");
                                        Console.WriteLine(" |                 |   o   |");
                                        Console.WriteLine(" |                  -------");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                   / | \\ ");
                                        Console.WriteLine(" |                  /  |   \\ ");
                                        Console.WriteLine(" |                 /   |     \\ ");
                                        Console.WriteLine(" |                     |   ");
                                        Console.WriteLine(" |                    / \\");
                                        Console.WriteLine(" |                   /   \\  ");
                                        Console.WriteLine(" |                  /     \\ ");
                                        for (int j = 0; j <= 2; j++)
                                        {
                                                Console.WriteLine(" |");

                                        }
                                        Console.WriteLine("__________");
                                        break;
                        }
                }
                public static void HideWord(string hideWord){
                        Console.WriteLine("Palabra a buscar: ");
                        Console.WriteLine(hideWord);
                }
        }
}