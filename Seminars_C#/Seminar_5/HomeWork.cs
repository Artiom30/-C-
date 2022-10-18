// Задача 1:  Задайте массив заполненный случайными положительными трёхзначными 
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

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите
//            сумму элементов, стоящих на нечётных позициях.
//            [3, 7, 23, 12] -> 19
//            [-4, -6, 89, 6] -> 0
/*
int[] RandomArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 100);
    return array;
}

void SumOfOddIndex(int[] array)
{
    int sumOfNum = 0;
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0 || array[i] / 10 > 0) Console.Write($" {i} ");
        else Console.Write(i + " ");
        if (i % 2 == 1) sumOfNum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine("The sum of all numbers in odd positions = " + sumOfNum);
}

Console.WriteLine("ENTER a size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArr(size);
SumOfOddIndex(array);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//             максимальным и минимальным элементов массива.
//             [3 7 22 2 78] -> 76

/*
void DoubArrDiffMinMax(int size)
{
    double[] array = new double[size];
    double min = 0;
    double max = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-10, 11)); // Они то вещественные, но в терминале не видно...
        Console.Write(array[i] + " ");
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i]; // так писать грамотно?
    }
    Console.WriteLine();
    Console.WriteLine($"The difference between {min} and {max} is {max - min}.");
}

Console.WriteLine("Specify the number of elements in the array:");
int size = Convert.ToInt32(Console.ReadLine());
DoubArrDiffMinMax(size);
*/