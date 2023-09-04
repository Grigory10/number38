using System.Security.Cryptography;
using System;
namespace number34
{
    internal class pivas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество символов");
            double CountElements = Convert.ToDouble(Console.ReadLine());
            double[] numbers = new double[(int)CountElements];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"введите значение под индексом {i}");
                numbers[i] = Convert.ToDouble(Console.ReadLine());

            }
            double max = numbers[0];
            double min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            double resoult = max - min;
            Console.WriteLine(resoult);


        }
    }
}