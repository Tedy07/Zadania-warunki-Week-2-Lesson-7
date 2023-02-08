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
            int number1;
            int number2;

            Console.WriteLine("Podaj pierwszą cyfrę ...");
            number1 = int.Parse( Console.ReadLine());

            Console.WriteLine("Podaj drugą cyfrę ...");
            number2 = int.Parse( Console.ReadLine());

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

            // Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.





        }
    }
}