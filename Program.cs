// Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90]. 

using System;



class Program

{
    static void Main(string[] args)
{
     int[] array = new int[10] { 10, 21, 14, 93, 23, 30, 75, 80, 95, 50 };
    

     for (int i = 0; i < 10; i++)

    {
          array[i] = i + 1;
    }

     int count = 0;

       for (int i = 0; i < 10; i++)

    {
      if (array[i] >= 20 && array[i] <= 90)

    {
         count++;
    }

        }

    Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20, 90]: " + count);

 }

}