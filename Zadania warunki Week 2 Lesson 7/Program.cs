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
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą cyfrę ...");
            int number1 = int.Parse(Console.ReadLine());

            if (number == number1)
            {
                Console.WriteLine("Cyfry {0} i {1} są równe.", number, number1);
            }
            else
            {
                Console.WriteLine("Cyfry {0} i {1} nie są równe.", number, number1);
            }

            // wersja druga
            Console.WriteLine(number == number1 ? $"Cyfry {number} i {number1} są równe." : $"Cyfry {number} i {number1} nie są równe.");

            //2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
            Console.WriteLine("\nZadanie nr 2");
            Console.WriteLine("Sprawdz czy dana liczba jest parzysta.");

            Console.WriteLine("\nPodaj liczbę ...");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(number2 % 2 == 0 ? $"{number2} jest liczbą parzysta" : $"{number2} jest liczbą NIEparzysta");

            // 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            Console.WriteLine("\nZadanie nr 3");
            Console.WriteLine("Sprawdz czy dana liczba jest dodatnia.");

            Console.WriteLine("\nPodaj liczbę ...");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(number3 >= 0 ? $"{number3} jest liczbą dodatnią" : $"{number3} jest liczbą ujemną");

            // 4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            Console.WriteLine("\nZadanie nr 4");
            Console.WriteLine("Czy podany rok jest rokiem przestępnym?");

            Console.WriteLine("\nPodaj rok ...");
            int year = int.Parse(Console.ReadLine());

            int yearPer4 = year % 4;
            int yearPer400 = year % 400;
            int yearPer100 = year % 100;

            if (yearPer4 == 0)
            {
                if (yearPer400 == 0 && yearPer100 == 0)
                {
                    Console.WriteLine($"{year} jest rokiem przestępnym");
                }
                else if ((yearPer4 == 0) && (yearPer400 != 0 && yearPer100 != 0))
                {
                    Console.WriteLine($"{year} jest rokiem przestępnym");
                }
                else
                {
                    Console.WriteLine($"{year} NIE jest rokiem przestępnym");
                }
            }
            else
            {
                Console.WriteLine($"{year} NIE jest rokiem przestępnym");
            }

            // 5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta.
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

            // 6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            Console.WriteLine("\nZadanie nr 6");
            Console.WriteLine("Sprawdz w jakiej grupie znajdujesz się według wzrost.");

            Console.WriteLine("\nPodaj wzrost ...");
            int height = int.Parse(Console.ReadLine());

            if (height <= 30)
            {
                Console.WriteLine("Jeszcze się nie urodziłeś");
            }
            else if (height <= 60)
            {
                Console.WriteLine("Jesteś niemowlakiem");
            }
            else if (height <= 100)
            {
                Console.WriteLine("Jesteś dzieckiem");
            }
            else if (height <= 150)
            {
                Console.WriteLine("Jesteś nastolatkiem");
            }
            else
            {
                Console.WriteLine("Jesteś dorosły");
            }

            // 7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa.
            Console.WriteLine("\nZadanie nr 7");
            Console.WriteLine("Program pobierze 3 liczby i sprawdzi, która jest największa.");

            Console.WriteLine("\nPodaj pierwszą liczbę ...");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę ...");
            int SecondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę ...");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= SecondNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine($"{firstNumber} jest największą z podanych.");
                }
                else
                {
                    Console.WriteLine($"{thirdNumber} jest największą z podanych.");
                }
            }
            else if (SecondNumber >= thirdNumber)
            {
                Console.WriteLine($"{SecondNumber} jest największą z podanych.");

            }
            else
            {
                Console.WriteLine($"{thirdNumber} jest największą z podanych.");
            }

            // 8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach.
            Console.WriteLine("\nZadanie nr 8");
            Console.WriteLine("Program sprawdza czy kandydat może ubiegać się o miejsce na studiach.");

            Console.WriteLine("\nPodaj wynik z matury z matematyki ...");
            int mathematics = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z matury z fizyki ...");
            int physics = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z matury z chemii ...");
            int chemistry = int.Parse(Console.ReadLine());

            int score1 = mathematics + physics + chemistry;


            if ((mathematics > 70) && (physics > 55) && (chemistry > 45) && (score1 > 180))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (((mathematics + physics) > 150) || ((mathematics + chemistry) > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat NIE dopuszczony do rekrutacji");
            }

            // 9.Napisz program, który odczyta temperaturę i zwróci odpowiednią nazwę.
            Console.WriteLine("\nZadanie nr 9");
            Console.WriteLine("Program, który odczyta temperaturę i zwróci odpowiednią nazwę.");

            Console.WriteLine("\nPodaj temperaturę ...");
            int temp = int.Parse(Console.ReadLine());

            if (temp <= 0)
            {
                Console.WriteLine("bardzo zimno");
            }
            else if (temp <= 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp <= 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp <= 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź, wyprowadzam się na Alaskę");
            }

            // 10.Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt.
            Console.WriteLine("\nZadanie nr 10");
            Console.WriteLine("Program, który sprawdzi czy z 3 podanych długości można stworzyć trójkąt.");

            Console.WriteLine("\nPodaj pierwszy długość ...");
            int length1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą długość ...");
            int length2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią długość ...");
            int length3 = int.Parse(Console.ReadLine());

            if ((length1 + length2 > length3) && (length1 + length3 > length3) && (length2 + length3 > length1))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("NIE można zbudować trójkąt");
            }

            // 11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            Console.WriteLine("\nZadanie nr 11");
            Console.WriteLine("Podaj ocenę jaką uzyskał uczeń ...");

            int rating = int.Parse(Console.ReadLine());

            switch (rating)
            {
                case 1:
                    Console.WriteLine("niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("dostateczny");
                    break;
                case 4:
                    Console.WriteLine("dobry");
                    break;
                case 5:
                    Console.WriteLine("bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("celujący");
                    break;
                default:
                    Console.WriteLine("Podałeś nieprawidłową ocenę");
                    break;

                    Console.ReadKey();
            }

            // inny sposób wykonania zadania 11, wersja druga
            Console.WriteLine("\nPodaj ocenę jaką uzyskał uczeń ...");
            int ratingB = int.Parse(Console.ReadLine());

            var resultB = ratingB switch
            {
                1 => "niedostateczny",
                2 => "dopuszczający",
                3 => "dostateczny",
                4 => "dobry",
                5 => "bardzo dobry",
                6 => "celujący",
                _ => "Podałeś nieprawidłową ocenę",
            };
            Console.WriteLine($"{resultB}");

            // 12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę.
            Console.WriteLine("\nZadanie 12. Dzień tygodnia");

            Console.WriteLine("\nPodaj numer dnia tygodnia ...");

            int numberDay = int.Parse(Console.ReadLine());

            var resultWeekDay = numberDay switch
            {
                1 => "poniedziałek",
                2 => "wtorek",
                3 => "środa",
                4 => "czwartek",
                5 => "piątek",
                6 => "sobota",
                7 => "niedziela",
                _ => "Podałeś niewłąściwą cyfrę",
            };
            Console.WriteLine($"{numberDay}. {resultWeekDay}");

            // 13. Napisz program, który będzie posiadał proste menu i będzie prostym kalkulatorem.
            Console.WriteLine("\n13. Prosty kalkulator");

            Console.WriteLine("\nPodaj pierwszą liczbę ...");
            double firstNumber13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ...");
            double secondNumber13 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie\n");

            int option = int.Parse(Console.ReadLine());
            double result = 0;

            if (option == 1)
            {
                result = firstNumber13 + secondNumber13;
                Console.WriteLine($"Twój wynik to {result}");
            }
            else if (option == 2)
            {
                result = firstNumber13 - secondNumber13;
                Console.WriteLine($"Twój wynik to {result}");
            }
            else if (option == 3)
            {
                result = firstNumber13 * secondNumber13;
                Console.WriteLine($"Twój wynik to {result}");
            }
            else if (option == 4)
            {
                if (secondNumber13 != 0)
                {
                    result = firstNumber13 / secondNumber13;
                    Console.WriteLine($"Twój wynik to {result}");
                }
                else
                {
                    Console.WriteLine("Pamiętaj nie dzielimy przez zero.");
                }
            }
            else
            {
                Console.WriteLine("Wybrałeś niewłaściwy numer operacji do wykonania");
            }

            //    wersja nr 2 zadania 13-ego.
            Console.WriteLine("\nWersja nr 2");

            Console.WriteLine("\nPodaj pierwszą liczbę ...");
            double firstNo13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ...");
            double secondNo13 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie\n");

            int option2 = int.Parse(Console.ReadLine());
            double result2 = 0;

            switch (option2)
            {
                case 1:
                    result2 = firstNo13 + secondNo13;
                    Console.WriteLine($"Twój wynik to {result2}");
                    break;
                case 2:
                    result2 = firstNo13 - secondNo13;
                    Console.WriteLine($"Twój wynik to {result2}");
                    break;
                case 3:
                    result2 = firstNo13 * secondNo13;
                    Console.WriteLine($"Twój wynik to {result2}");
                    break;
                case 4:
                    if (secondNo13 == 0)
                    {
                        Console.WriteLine("Pamiętaj nie dzielimy przez 0");
                    }
                    else
                    {
                        result2 = firstNo13 / secondNo13;
                        Console.WriteLine($"Twój wynik to {result2}");
                    }
                    break;
                default:
                    Console.WriteLine("Wybrałeś niewłaściwy numer operacji do wykonania");
                    break;
            }
        }
    }
}

