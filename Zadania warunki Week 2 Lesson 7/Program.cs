using System.Text;

namespace Zadania_warunki_Week_2_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            // wersja pierwsza 

            int a = 5;
            int b = 5;
            bool result;
            
            if (a == b)
            {
                result = true;
                Console.WriteLine("Zmienna {0} i {1} są równe", a, b);
            } else
            {
                result = false;
                Console.WriteLine("Zmienne {0} i {1} nie są równe", a, b);
            }

            // wersja druga
            string resultB;
            resultB = a == b ? "Zmienna {0} i {1} są równe" : "Zmienne {0} i { 1} nie są równe";


            // Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.





        }
    }
}