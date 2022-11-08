// Семинар 7.
// Тема:

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
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] CreateRandomMarix()
{
    Console.WriteLine("Imput a Matrix size: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
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

// Задача 1:
// Задача 2:
// Задача 3:
// Задача 4:
