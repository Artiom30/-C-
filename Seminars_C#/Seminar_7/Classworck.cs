// Семинар 7: Двумерные массивы.

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными 
//           целыми числами.

/*
// Метод для создания двумерного массива со случайными значениями.
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

// Метод для вывода двумерного массива в терминал.
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
*/

// int [,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);

// Задача 2.Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//          по формуле: Aij = i+j. Выведите полученный массив на экран.

/*
int[,] SumIndex2DArray()
{
    Console.WriteLine("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i + j;
    return array;
}

int[,] resultArray = SumIndex2DArray();
Show2DArray(resultArray);
*/




/*
// Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//           и замените эти элементы на их квадраты. 
// Метод void. 

void HonestEventIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];        
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);
Console.WriteLine();
HonestEventIndex(array);
Show2DArray(array);
*/

/*
// Задача 4.Задайте двумерный массив. Найдите сумму элементов, находящихся на
//          главной диагонали (с индексами (0,0); (1;1) и т.д.)

int SumElementOfDiagonal(int [,]array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
          sum +=array[i,i];  
    }
    return sum;
}

int [,] array = CreateRandom2DArray();

Show2DArray(array);
Console.WriteLine(SumElementOfDiagonal(array));
*/

