/*
int[,] CreateRandom2DArray()
{
    Console.WriteLine("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}
*/
/*
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными
//           вещественными числами.
//           m = 3, n = 4.
//           0,5   7   -2   -0,2
//           1   -3,3   8   -9,9
//           8    7,8  -7,1   9

double[,] RealArray ()
{
    Console.WriteLine("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int whole = 0;
    double[,] array = new double[rows,columns];
    double remainder = 0;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {    
            remainder = Math.Round(new Random().NextDouble(), 1);
            whole = new Random().Next(minValue, maxValue + 1);
            array[i,j] = whole + remainder;
        }
    return array;


}

void Show2DArrayReal(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

double[,] realArray = RealArray();
Show2DArrayReal(realArray);
*/
/*
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в 
//            двумерном массиве, и возвращает значение этого элемента или же указание, 
//            что такого элемента нет.
//            Например, задан массив:
//            1 4 7 2
//            5 9 2 3
//            8 4 2 4
//     1 7 -> числа с такими индексами в массиве нет

void ContentIndexArray(int[,] array, int n, int m)
{
    if (n <= array.GetLength(0) && m <= array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                if (i == n && j == m) Console.WriteLine("In this cell: "+ array[i, j]);
    }
    else Console.WriteLine("There is no cell with this address in this array.");
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);
Console.WriteLine("Enter the address of the array cell.");
Console.WriteLine("line address:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Column address:");
int column = Convert.ToInt32(Console.ReadLine());
ContentIndexArray(array, line, column);
*/

/*
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//            элементов в каждом столбце.
//            Например, задан массив:
//            1 4 7 2
//            5 9 2 3
//            8 4 2 4
//            Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] AverageOfIndexCol2DArray(int[,] array)
{
    double[] AverageOfIndexColumns = new double[array.GetLength(1)];
    for (int j = 0, k = 0; j < array.GetLength(1) && k < AverageOfIndexColumns.Length; j++, k++)
    {
        double sum = 0;
        double Average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Average = sum / array.GetLength(0);
        AverageOfIndexColumns[k] = Math.Round(Average, 2);
    }
    return AverageOfIndexColumns;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"Col{i + 1} ({array[i]}) ");
    Console.WriteLine();
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);

Console.WriteLine("Arithmetic mean of each array column:");
double[] AverageOfIndexColumns = AverageOfIndexCol2DArray(array);
PrintArray(AverageOfIndexColumns);
*/
