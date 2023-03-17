using System;
namespace StrangleGame
{
        class Program
        {
                static void Main(string[] args)
                {
                        string value = "";
                        do
                        {
                                // Aplicamos color a la fuente 
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("======================AHORCADO EN C#======================");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (value == "--")
                                {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Opcion no valida");
                                        Console.ForegroundColor = ConsoleColor.White;
                                }

                                Console.WriteLine("");
                                Console.WriteLine("Opciones del juego: ");
                                Console.WriteLine("1) Jugar una partida.");
                                Console.WriteLine("2) Mostrar informacion del autor.");
                                Console.WriteLine("X) Salir del juego.");
                                Console.Write("Seleccione la opcion del juego:");
                                Console.WriteLine("");

                                value = Console.ReadLine();

                                switch (value)
                                {
                                        case "1":
                                                Console.WriteLine("Vamos a jugar");
                                                Game game = new Game();
                                                game.Play();
                                                break;
                                        case "2":
                                                Console.WriteLine("Marcos Ariel Palo (marcospalodevs@gmail.com / marcospalo22@gmail.com)");
                                                Console.WriteLine("Curso\"Master en Programacion C# con Visual Studio Code\"");
                                                break;
                                        case "X":
                                                Console.WriteLine("Gracias por jugar :), nos vemos.");
                                                break;
                                        default:
                                                value = "--";
                                                break;
                                }
                        } while (value == "--");
                }
        }
}