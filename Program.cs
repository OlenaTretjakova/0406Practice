using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0406Practice
{
    internal class Program
    {
        public static void GuessNum()
        {
            Console.WriteLine("Enter start diapason:");
            int startDiapason = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end diapason:");
            int endDiapason = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomNumber = rnd.Next(startDiapason, endDiapason + 1);

            int userChoice = 0;

            while (userChoice != 3)
            {
                Console.WriteLine($"My number:{randomNumber}");

                Console.WriteLine("More 1, less 2, you guessed !: 3 ");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        startDiapason = randomNumber;
                        randomNumber = rnd.Next(startDiapason, endDiapason + 1);
                        break;
                    case 2:
                        endDiapason = randomNumber;
                        randomNumber = rnd.Next(startDiapason, endDiapason + 1);
                        break;
                    case 3:
                        Console.WriteLine("Game over! You guessed ! ");
                        break;
                    default:
                        Console.WriteLine("Incorrect choice, try again! ");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Even number: ");

            EvenNum num = new EvenNum(4);
            Console.WriteLine(num);

            Console.WriteLine("The game guess the number: ");
            GuessNum();

            Triangl tr1 = new Triangl(90, 45, 45, 20, 10, 10);

            tr1.ShowTriangl(90, 45, 45, 20, 10, 10);

            PseudoText text1 = new PseudoText("aeuioj", "qwertplkhgfdszxcvbnm", 7);

            text1.ShowSentence();

            Console.ReadLine();
        }
    }

    
}
