using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 101);
            int counter = 1;
            int userNumber;

            try
            {
                do
                {
                    Console.WriteLine("Zgadnij wylosowaną liczbę z zakresu od 0 do 100");
                    userNumber = GetInput();

                    if (userNumber > randomNumber)
                    {
                        Console.WriteLine("Podana liczba jest zbyt duża");
                        counter++;
                    }
                    else if (userNumber < randomNumber)
                    {
                        Console.WriteLine("Podana liczba jest zbyt mała");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"Brawo!!! Wylosowana liczba to : {randomNumber}. Zgadłeś za {counter} razem");
                    }

                } while (randomNumber != userNumber);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static int GetInput()
        {
            if(!int.TryParse(Console.ReadLine(), out int input))
            {
                throw new Exception("Podana wartość jest nieprawidłowa");
            }
            return input;
        }
    }
}
