// Задача 34:  Задайте массив заполненный случайными положительными трёхзначными 
//             числами. Напишите программу, которая покажет количество чётных чисел в 
//             массиве.
//             [345, 897, 568, 234] -> 2
/*
int[] ThreeDigArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void CounterTwoDigNum(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0) counter += 1;
    }
    Console.WriteLine();
    Console.WriteLine($"In this array {counter} of even numbers.");
}
Console.WriteLine("Hi. Imput a size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here is an array of three digit numbers.");
int[] array = ThreeDigArray(size);
CounterTwoDigNum(array);
*/