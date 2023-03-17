using System;
using System.IO;
namespace StrangleGame
{
        class Game
        {
                // Vamos a añadir las proipiedades del juego ahorcado, ejemplo:
                // intentos, palabras, letras, etc.

                // Intentos necesarios
                public int Attemps { get; set; } // En general 6

                // Palabra secreta
                public string? HideWord { get; set; }

                // Palabra oculta "encriptada"
                public string? GameWordChardShow { get; set; }

                // Listas para el flujo del juego
                public List<char>? InputCharList { get; set; }
                public List<char>? HideWordChars { get; set; } // se almacenan por defecto asi => "_"
                public List<char>? CorrectChars { get; set; } // marcos => 'm','a', 'r','c','o', 's'

                public Game()
                {
                        // Intentos por defecto 6
                        Attemps = 6;
                        // Añadimos palabra oculta fija
                        HideWord =  GetHideWord();
                        // Convertir el HideWord en array de chars para aplicar las listas necesarias
                        char[] charListElements = (HideWord.ToLower()).ToCharArray();

                        // Inicializar la lista para los caracteres que vamos introduciendo
                        InputCharList = new List<char>();

                        HideWordChars = new List<char>(charListElements);

                        CorrectChars = new List<char>(charListElements);

                        for (int i = 0; i < HideWordChars.Count; i++)
                        {
                                if (HideWordChars[i] != ' ')
                                {
                                        HideWordChars[i] = '_';
                                        GameWordChardShow += "_ ";
                                }
                                else
                                {
                                        GameWordChardShow += "  ";
                                }
                        }
                        Draw.Image(Attemps, HideWord);
                        Draw.HideWord(GameWordChardShow);
                }
                public void Play(){
                        // Mientras jugamos
                        while(Attemps > 0 && HideWordChars.Contains('_')){
                                
                                // Introducir el caracter desde la consola con el teclado
                                char inputChar = ' ';
                                Console.WriteLine("\nIngrese una letra: ");
                                try{
                                       inputChar = Console.ReadLine().ToLower() [0]; //Usando el [0] tomaremos el primer caracter de lo que se haya ingresado en consola
                                } catch(IndexOutOfRangeException){
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Debes de añadir algo de informacion");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        inputChar = '.';
                                } catch (Exception exc){
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("ERROR general: {0}", exc);
                                        Console.ForegroundColor = ConsoleColor.White;
                                }

                                // Comprobar que es un caracter valido
                                if(inputChar >= 'a' && inputChar <= 'z'){
                                        // Comprobar que ese caracater se ha ingresado antes
                                        if(!InputCharList.Contains(inputChar)){
                                                Console.Clear();
                                                // Añadir para no repetir caracteres
                                                InputCharList.Add(inputChar);

                                                // Comprobar si existe en la palabra oculta
                                                CheckExistCharInWord(inputChar);

                                                // Dibujar el estado dependiendo del resultado dado en la comprobacion
                                                Draw.Image(Attemps, HideWord);
                                                Draw.HideWord(GameWordChardShow);
                                        } else{
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("Ya ingresaste el caracter '{0}'. Prueba con otra letra.", inputChar);
                                                Console.ForegroundColor = ConsoleColor.White;

                                        }
                                }
                        }
                        // Partida Finalizada
                        if (Attemps == 0){
                                Draw.Image(Attemps, HideWord); // Quedaron letras sin encontrar
                        }else if(!HideWordChars.Contains('_')){
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("VAMOOOOO CAMPEON GANASTE");
                                Console.ForegroundColor = ConsoleColor.White;
                        }
                }
                private string GetHideWord(){
                        List<string> hideWords = LoadWordChars();
                        Random random = new Random(); // Usamos la clase Random para generar un string aleatorio
                        int numberRandom = random.Next(0, hideWords.Count);

                        return hideWords[numberRandom];
                }
                private List<string> LoadWordChars(){ // Cargamos las palabras de los archivos
                        string loadText = File.ReadAllText(@"c:\Users\Marcos\Desktop\Curso_C#\Proyecto\StrangleGame\data\Paises.txt"); // c:\Users\Marcos\Desktop\Curso_C#\Proyecto\StrangleGame\data\sagas-sony.txt
                        string [] words = loadText.Split('/');
                        
                        return new List<string>(words);
                }
                private void CheckExistCharInWord(char inputchar){
                        // Comprobar que existe dentro de CorrectChars
                        if(CorrectChars.Contains(inputchar)){

                                // Acertamos
                                GameWordChardShow = ""; 
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Has acertado :)");
                                Console.ForegroundColor = ConsoleColor.White;
                                for(int i = 0; i < HideWordChars.Count; i++){

                                        if(CorrectChars[i] == inputchar){
                                                HideWordChars[i] = inputchar;
                                        }
                                        GameWordChardShow += (HideWordChars[i] != ' ') ? HideWordChars[i] + " ":  "  ";
                                }
                        } else{
                                // No acertamos
                                Attemps --;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No has acertado, lo siento :(");
                                Console.ForegroundColor = ConsoleColor.White;

                        }
                }
        }
}