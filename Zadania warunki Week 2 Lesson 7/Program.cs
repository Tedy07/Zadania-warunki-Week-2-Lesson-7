using System.Text;

namespace Zadania_warunki_Week_2_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            // wersja pierwsza 

            Console.WriteLine("Zadanie nr 1");

            Console.WriteLine("Podaj pierwszą cyfrę ...");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą cyfrę ...");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Cyfry {0} i {1} są równe.", number1, number2);
            }
            else
            {
                Console.WriteLine("Cyfry {0} i {1} nie są równe.", number1, number2);
            }

            // wersja druga
            Console.WriteLine(number1 == number2 ? $"Cyfry {number1} i {number2} są równe." : $"Cyfry {number1} i {number2} nie są równe.");

            // 2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.

            Console.WriteLine("\nZadanie nr 2");
            
            Console.WriteLine("Sprawdz czy dana liczba jest parzysta.");
            Console.WriteLine("Podaj liczbę ...");

            int number3 = int.Parse(Console.ReadLine());
            double result1 = number3 % 2;

            Console.WriteLine(result1 == 0 ? $"{number3} jest liczbą parzysta" : $"{number3} jest liczbą NIEparzysta");

            // 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.

            Console.WriteLine("\nZadanie nr 3");
            
            Console.WriteLine("Sprawdz czy dana liczba jest dodatnia.");
            Console.WriteLine("Podaj liczbę ...");

            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine( number4 >=0 ? $"{number4} jest liczbą dodatnią" : $"{number4} jest liczbą ujemną");




        }
    }
}