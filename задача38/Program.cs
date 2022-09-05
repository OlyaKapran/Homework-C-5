using System;

namespace задача38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:  ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[size];
            void FillArray(double[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                {
                   
                    numbers[i] = new Random().Next(1,100);
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("] ");
                Console.Write("-> ");
            }
            FillArray(numbers);
            double max = numbers[0];
            double min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i]) max = numbers[i];
                if (min > numbers[i]) min = numbers[i];
            }
            double result = max - min;

            Console.WriteLine($"{max} - {min} = {result} разница между максимальным и минимальным элементов массива");
        }
    }
}
