using System;

namespace задача34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:  ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            void FillArray(int[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                {
                   
                    numbers[i] = new Random().Next(100,1000);
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("] ");
                Console.Write("-> ");
            }
            FillArray(numbers);
            
            int count = 0;

            for (int z = 0; z < numbers.Length; z++)
            {
                if (numbers[z] % 2 == 0)
                count++;
            }
            Console.WriteLine($"{count} четных чисел ");
        }
    }
}
