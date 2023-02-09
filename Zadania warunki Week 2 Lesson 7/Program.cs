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

            //Console.WriteLine("\nZadanie nr 5");

            //Console.WriteLine("Jaki wiek uprawnia do ubiegania się o stanowisko posła, sentarora, premiera, prezydenta?");
            //Console.WriteLine("\nPodaj wiek osoby ...");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 35)
            //{
            //    Console.WriteLine("Możesz zostać prezydentem, premierem, senatorem lub posłem.");
            //}
            //else if (age >= 30)
            //{
            //    Console.WriteLine("Możesz zostać premierem, senatorem lub posłem.");
            //}
            //else if (age >= 21)
            //{
            //    Console.WriteLine("Możesz zostać posłem.");
            //}
            //else
            //{
            //    Console.WriteLine("Jesteś zbyt młody aby zostać prezydentem, premierem, senatorem lub posłem.");
            //}

            // 6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            //Console.WriteLine("\nZadanie nr 6");

            //Console.WriteLine("Sprawdz w jakiej grupie znajdujesz się według wzrost.");
            //Console.WriteLine("\nPodaj wzrost ...");
            //int height = int.Parse(Console.ReadLine());

            //if ((height >= 0) && (height <= 30))
            //{
            //    Console.WriteLine("Jeszcze się nie urodziłeś");
            //}
            //else if ((height >= 31) && (height <= 60))
            //{
            //    Console.WriteLine("Jesteś niemowlakiem");
            //}
            //else if ((height >= 61) && (height <= 100))
            //{
            //    Console.WriteLine("Jesteś dzieckiem");
            //}
            //else if ((height >= 101) && (height <= 150))
            //{
            //    Console.WriteLine("Jesteś nastolatkiem");
            //}
            //else if (height >= 151)
            //{
            //    Console.WriteLine("Jesteś dorosły");
            //}
            //else
            //{
            //    Console.WriteLine("Nie podałeś poprawnego wzrostu");
            //}

            // 7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa.
            //Console.WriteLine("\nZadanie nr 7");

            //Console.WriteLine("Program pobierze 3 liczby i sprawdzi, która jest największa.");
            //Console.WriteLine("\nPodaj pierwszą liczbę ...");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj drugą liczbę ...");
            //int numberTwo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj trzecią liczbę ...");
            //int numberThree = int.Parse(Console.ReadLine());

            //if (numberOne >= numberTwo)
            //{
            //    if (numberOne >= numberThree)
            //    {
            //        Console.WriteLine($"{numberOne} jest największą z podanych.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{numberThree} jest największą z podanych.");
            //    }
            //}
            //else if (numberTwo >= numberThree)
            //{
            //    Console.WriteLine($"{numberTwo} jest największą z podanych.");

            //}
            //else
            //{
            //    Console.WriteLine($"{numberThree} jest największą z podanych.");
            //}

            // 8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach.
            //    Console.WriteLine("\nZadanie nr 8");

            //    Console.WriteLine("Program sprawdza czy kandydat może ubiegać się o miejsce na studiach.");
            //    Console.WriteLine("\nPodaj wynik z matury z matematyki ...");
            //    int mathematics = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Podaj wynik z matury z fizyki ...");
            //    int physics = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Podaj wynik z matury z chemii ...");
            //    int chemistry = int.Parse(Console.ReadLine());

            //    int score1 = mathematics + physics + chemistry;


            //    if ((mathematics > 70) && (physics > 55) && (chemistry > 45) && (score1 > 180))
            //    {
            //        Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            //    }
            //    else if (((mathematics + physics) > 150) || ((mathematics + chemistry) > 150))
            //    {
            //        Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kandydat NIE dopuszczony do rekrutacji");
            //    }

            //9.Napisz program, który odczyta temperaturę i zwróci odpowiednią nazwę.
            //Console.WriteLine("\nZadanie nr 9");

            //Console.WriteLine("Program, który odczyta temperaturę i zwróci odpowiednią nazwę.");
            //Console.WriteLine("\nPodaj temperaturę ...");
            //int temp = int.Parse(Console.ReadLine());

            //if (temp < 0)
            //{
            //    Console.WriteLine("bardzo zimno");
            //}
            //else if ((temp >= 0) && (temp < 10))
            //{

            //    Console.WriteLine("zimno");
            //}
            //else if ((temp >= 10) && (temp < 20))
            //{
            //    Console.WriteLine("chłodno");
            //}
            //else if ((temp >= 20) && (temp < 30))
            //{
            //    Console.WriteLine("w sam raz");
            //}
            //else if ((temp >= 30) && (temp < 40))
            //{
            //    Console.WriteLine("zaczyna być słabo, bo gorąco");
            //}
            //else if (temp >= 40)
            //{
            //    Console.WriteLine("a weź, wyprowadzam się na Alaskę");
            //}

            //10.Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt.
            Console.WriteLine("\nZadanie nr 10");

            Console.WriteLine("Program, który sprawdzi czy z 3 podanych długości można stworzyć trójkąt.");
            Console.WriteLine("\nPodaj pierwszy długość ...");
            int length1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą długość ...");
            int length2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią długość ...");
            int length3 = int.Parse(Console.ReadLine());




        }

    }
}
