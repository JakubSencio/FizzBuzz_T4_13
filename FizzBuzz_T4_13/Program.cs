using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_T4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.
            -Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.
            -Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać zwrócony wynik „FizzBuzz”.
            -Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.
            Niech to będzie nowa metoda niestatyczna w osobnej klasie o nazwie FizzBuzz. Najlepiej jak sama metoda będzie zwracała string’a, który zostanie zwrócony i wyświetlony w klasie Program w metodzie Main.*/
            var exitGame = false;

            int numberInput;

            var FizzBuzz = new Interface();
            Console.WriteLine("Witaj! Wprowadz liczbe do gry, a zostanie zwrocony Ci odpowiedni wynik. Aby wyjsc z gry wpisz do konsoli '0'."); Console.WriteLine("Uwaga! Liczba musi byc > 0.");
            try
            {
                while (!exitGame)
                {
                    numberInput = int.Parse(Console.ReadLine());

                    if (numberInput > 0)
                    {
                        Console.WriteLine(FizzBuzz.FizzBuzzGame(numberInput));
                    }
                    else if(numberInput == 0)
                    {
                        Console.WriteLine("Koniec gry!");
                        exitGame = true;
                    }
                    else
                    {
                        Console.WriteLine("Liczba musi byc wieksza od 0");
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Blad wprowadzenia danych");
            }
        }
    }
}
