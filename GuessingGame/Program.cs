using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guessing Game!!");
            Random r = new Random();
            var TextPrint = new TextColor();
            var number = r.Next(1, 10);
            var win = false;
            do
            {
                Console.WriteLine("Guess a number between 1 to 10");
                var guess = Console.ReadLine();
                if ( Int32.Parse(guess) == number)
                {
                    TextPrint.ConsoleText(ConsoleColor.DarkGreen, "CONGRATS YOU WIN!!!");
                    win = true;
                }
                else
                {
                    TextPrint.ConsoleText(ConsoleColor.DarkRed, "Incorrect, please try again.");
                }
            } while (win == false);  
        }
        public class TextColor
        {
            public void ConsoleText(ConsoleColor color, string text)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
        }
    }

}
