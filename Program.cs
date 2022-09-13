using System.Runtime.Intrinsics.X86;

namespace Numberguessergame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);
                bool check = false;

                while (guess != number)
                {
                    while (check == false)
                    {
                        try
                        {
                            Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                            guess = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch
                        {
                            Console.WriteLine("Geben Sie Zahlen zwischen 1-100 ein!");
                            check = false;
                        }
                    }
                    check = false;
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU HAVE ACCOMPLISHED YOUR MISSION!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");                                       
Console.WriteLine("___________________________________________$$s                           ");
Console.WriteLine("_________________________$____$$s___________s$$s                         ");
Console.WriteLine("_________________________s$$$$s$$$$$$s________$$$___s$                   ");
Console.WriteLine("_______________s$$$$$$$$s___s$$$$ss$$$$s________$$$__$$                  ");
Console.WriteLine("________________________s$$$s__$$$$$s_$$$s___s$__s$$s_$$                 ");
Console.WriteLine("__________s$$$$$$$$$$$$$$$$$$$$sss$$$$s_$$$s__$$$__s$$s$                 ");
Console.WriteLine("_____s$$$$$$$$$s_____s$$$$$$$$$$$$$$h$$$__$$$s__$$___$$$s                ");
Console.WriteLine("___s$$$$$s_____________________ss$$$$$$$$s_s$$$s$$$__s$$$                ");
Console.WriteLine("__________________________s$$$s____s$$$$$$$$s$$$$$$$__$$$                ");
Console.WriteLine("_________s$$$$$$$$$$$$$$$s$$$$$$$$$$s$$$$$$$$$ss$$$$s_$$$                ");
Console.WriteLine("_____________________s$$$$$$$$$$s$$$s____s$$$$$$__$$$__$$                ");
Console.WriteLine("________________s$$$$$$$$$$$$$$$$$$$$$$s_____s$$$s_$$__$$                ");
Console.WriteLine("________s$$$$$$$$$$$$$$$$$$$$$$$s$s__s$$$$$$s___$$s_$s$$$                ");
Console.WriteLine("_____s$$$$$s$$$$$$$$$$$$$$s____$$s$$$$$$$$$$$$$s____$$$$s                ");
Console.WriteLine("___s$$$$__s$$$$$$$$$s_____s$$$$$s$$$$$$$$$$$$$$$$$s__$$$                 ");
Console.WriteLine("___s$___$$$$$$______s$$$$$$$s_s$$$$$$$$$$$$$$$$$$$$$____$$$              ");
Console.WriteLine("______s$$$s___s$$$$$$$$$$$___$$$$$$$$$$$$$$$$$$$$$$$$s$$$$$$$s           ");
Console.WriteLine("_____$$$__s$$$$$$$$$$$$$$__$$$$$$$$$$$$$$$$$$$$s$s$_$$$$$$$$$$$          ");
Console.WriteLine("____$$$_$$$$$$i$$$$$s_$$__$$$$$$$$$$$$$$$$$$$ss$$$s$$$$$$$$s$$s          ");
Console.WriteLine("___$$__$$$__s$$$$ss__$$_$$$$$$$$$$$$$$$$$$$$s$$$$$_$$$$e$$s$             ");
Console.WriteLine("__$$_s$$___$$$$s_$$_$$s$$$$$$$$$$$$$$$$$$$$s$$$$$s_$$$$$$s$              ");
Console.WriteLine("_s$s$$$___$$$$_s$$__$$__$$$$$$$$$$$$$$$$$$_$$$$$$$_s_$$$                 ");
Console.WriteLine("_$$s$s__s$$$__$$____s$$__$$$$$$$$$$$$$$$$$_$$$$$$$$__$$$                 ");
Console.WriteLine("$$_$___$$$$_s$$__$$__$$$s__s$$$$$$$$$$$$$$_$$$$$$$$$$$$s                 ");
Console.WriteLine("$$____$$$s_$$$__$$$_$_s$$$$s___s$s$$$$$$$$_$$$$$$$$s$$$                  ");
Console.WriteLine("$____$$$__$$sss$$$$__$_s$$$$$$$$$$s$s$$$$$___s$$$$s$$$s                  ");
Console.WriteLine("____$$$_s$$$_$s$$$$s_s$__$$$$$$___s$$s_$$$s___s$$$_$$$                   ");
Console.WriteLine("____$$_s$$$_$$_s$$$$$_s$$___$$$$$________$_____$$$s$$s                   ");
Console.WriteLine("___s$$_$$$__$$__$$$$$$$$$$s____s$$$$$_________s$$$$$$                    ");
Console.WriteLine("___$$$s$$$__$$___$$ss$$$$$$$$s____s$$$$$s______$$$$$$                    ");
Console.WriteLine("___$s$$$$$_s$$__s_$$$_s$$$$$$$$$$s___s$$$$$$$s___sss                     ");
Console.WriteLine("___$$$$$$$_$$$__$s_$$$$s__s$$$$$$$$$s___$$$$$$$s                         ");
Console.WriteLine("__s$$$$$$$_$$$s_s$__$$$$$$s__s$$$$$$$$$s__$__$$$$s                       ");
Console.WriteLine("__$_$$$$s$_s$$$__$$__$$$$$$$$s__$$s$$$$$$$_____$$$$                      ");
Console.WriteLine("____s$$$_$$_$$$___$$__$s$$$$$$$$_s__s$$$s$$$____$$$$                     ");
Console.WriteLine("_____$$$__$_$$$$___$$_ss_$$$$$$$$$____$$$$_s$____$$$s                    ");
Console.WriteLine("_____$$$s_$_s$$$s__$$$____s$$$$$$$$$___s$$$______$$$$                    ");
Console.WriteLine("_____s$$$_ss_$$$$___$$s____$$$$$$$$$$___$$$$_____s$$$                    ");
Console.WriteLine("______$k$__$__$$$$__s$$____$$$$$$$h$$____$$$$_____$$s                    ");
Console.WriteLine("______$$$______$$$s__$$$___$$_$$$$$$$$___s$$$$____$$                     ");
Console.WriteLine("_______$$s______$$$__s$$$___$_s$$$$$s____s$$$$____$s                     ");
Console.WriteLine("_______$$$_______$$$_s$$_$__$__$$$$$s____s$$$$___$$                      ");
Console.WriteLine("________$$_______s$$__$$_______$$$$$s____$$$$$___$s                      ");
Console.WriteLine("________$$________s$$_$$______s$$$$$_____$$_$$___$                       ");
Console.WriteLine("___________________$$_$$s_____$$$$$_____$$s_$s                           ");
Console.WriteLine("____________________$$s$$_____$$$$_____s$$__$                            ");
Console.WriteLine("____________________s$_$$____$$$s_____s$$                                ");
Console.WriteLine("_____________________$_$$___$$$______s$$                                 ");
Console.WriteLine("_______________________$$__s$$______$$$                                  ");
Console.WriteLine("________________________$__$$______$$$                                   ");
Console.WriteLine("________________________$_$$s____$$$s                                    ");
Console.WriteLine("__________________________$$___s$$s                                      ");
Console.WriteLine("__________________________$$__$$s                                        ");
                                                                                           

            Console.ReadKey();
        }
    }
}