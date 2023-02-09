using System.Text;

namespace Zadania_warunki_Week_2_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            //// wersja pierwsza 

            //Console.WriteLine("Zadanie nr 1");

            //Console.WriteLine("Podaj pierwszą cyfrę ...");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj drugą cyfrę ...");
            //int number1 = int.Parse(Console.ReadLine());

            //if (number == number1)
            //{
            //    Console.WriteLine("Cyfry {0} i {1} są równe.", number, number1);
            //}
            //else
            //{
            //    Console.WriteLine("Cyfry {0} i {1} nie są równe.", number, number1);
            //}

            //// wersja druga
            //Console.WriteLine(number == number1 ? $"Cyfry {number} i {number1} są równe." : $"Cyfry {number} i {number1} nie są równe.");

            //// 2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.

            //Console.WriteLine("\nZadanie nr 2");

            //Console.WriteLine("Sprawdz czy dana liczba jest parzysta.");
            //Console.WriteLine("\nPodaj liczbę ...");
            //int number2 = int.Parse(Console.ReadLine());

            //double result1 = number2 % 2;
            //Console.WriteLine(result1 == 0 ? $"{number2} jest liczbą parzysta" : $"{number2} jest liczbą NIEparzysta");

            //// 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.

            //Console.WriteLine("\nZadanie nr 3");

            //Console.WriteLine("Sprawdz czy dana liczba jest dodatnia.");
            //Console.WriteLine("\nPodaj liczbę ...");
            //int number3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(number3 >= 0 ? $"{number3} jest liczbą dodatnią" : $"{number3} jest liczbą ujemną");

            // 4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.

            //Console.WriteLine("\nZadanie nr 4");

            //Console.WriteLine("Czy podany rok jest rokiem przestępnym?");
            //Console.WriteLine("\nPodaj rok ...");
            //int year = int.Parse(Console.ReadLine());

            //int number4 = year % 4;
            //int number44 = year % 400;
            //int number444 = year % 100;
            //// sprawdzamy modulo z podanego roku

            //if (number4 == 0)
            //{
            //    if (number44 == 0 && number444 == 0)
            //    {
            //        Console.WriteLine($"{year} jest rokiem przestępnym");
            //    }
            //    else if ((number4 == 0) && (number44 != 0 && number444 != 0))
            //    {
            //        Console.WriteLine($"{year} jest rokiem przestępnym");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{year} NIE jest rokiem przestępnym");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{year} NIE jest rokiem przestępnym");
            //}

            // 5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta.

            Console.WriteLine("\nZadanie nr 5");

            Console.WriteLine("Jaki wiek uprawnia do ubiegania się o stanowisko posła, sentarora, premiera, prezydenta?");
            Console.WriteLine("\nPodaj wiek osoby ...");
            int age = int.Parse(Console.ReadLine());

            if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem, premierem, senatorem lub posłem.");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Możesz zostać premierem, senatorem lub posłem.");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem.");
            }
            else
            {
                Console.WriteLine("Jesteś zbyt młody aby zostać prezydentem, premierem, senatorem lub posłem.");
            }



        }
    }
}
