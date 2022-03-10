using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczający BMI");
            string again;
            do
            {
                double wzrost;
                double waga;
                double bmi;
                Console.WriteLine("Podaj wzrost w metrach");
                wzrost = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wagę w kilogramach");
                waga = double.Parse(Console.ReadLine());
                bmi = waga / (wzrost * wzrost);
                if (bmi < 18.5)
                {
                    Console.WriteLine("Niedowaga. Twoje BMI wynosi: {0}", bmi);
                }
                else if (bmi >= 25)
                {
                    Console.WriteLine("Nadwaga. Twoje BMI wynosi: {0}", bmi);
                }
                else
                {
                    Console.WriteLine("Waga prawidłowa. Twoje BMI wynosi: {0:F2}", bmi);
                }
                Console.WriteLine("Czy chcesz powtórzyć program? ");
                again = Console.ReadLine();
            } while (again == "t");
        }
    }
}
