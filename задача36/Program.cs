using System;

namespace задача36
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
                   
                    numbers[i] = new Random().Next(1,10);
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("] ");
                Console.Write("-> ");
            }
            FillArray(numbers);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0) sum = numbers[i] + sum;      
            }
            Console.Write($"сумма элементов, стоящих на нечётных позициях = {sum}");
        }
    }
}
