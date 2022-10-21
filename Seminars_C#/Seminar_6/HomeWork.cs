// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//           сколько чисел больше 0 ввёл пользователь.
//           0, 7, 8, -2, -2 -> 2
//           1, -7, 567, 89, 223-> 4

/*
void CounterNumbers()
{
    Console.WriteLine("Enter the numbers, and I will count how many are positive.");
    Console.WriteLine("How many numbers will we check?");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    Console.WriteLine("Number of positive numbers = " + count);
}

CounterNumbers();
*/


// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//           заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
//           k1, b2 и k2 задаются пользователем.
//           b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
