// Семинар 8.
// Тема: Решение задач с двумерными массивами.
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
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
*/

// Задача 1: Задайте двумерный массив. Напишите программу, которая заменяет 
//           строки на столбцы. В случае, если это невозможно, программа должна вывести 
//           сообщение для пользователя. (тенспонирование)

//    Транспонирование —  это операция над матрицами в результате 
//  которой матрица поворачивается относительно своей главной диагонали.
/*
void ChangeArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
        Console.WriteLine("Impossible to change");
    else
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
Console.WriteLine();
ChangeArray(myArray);
Show2DArray(myArray);


// 1 5 2     1 6 4
// 6 3 8     5 3 7   < =  Пример  замены строк на столбцы
// 4 7 9     2 8 9
*/

// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами 
//           две строки , каторые укажет пользователь.
/*
void ChangeStringArray(int[,] array, int firstStr, int lastStr)
{
    if (firstStr < array.GetLength(0) && lastStr < array.GetLength(0))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[firstStr, j];
            array[firstStr, j] = array[lastStr, j];
            array[lastStr, j] = temp;
        }
    else
        Console.WriteLine("Uncorrected lines!");
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
Console.WriteLine("Imput first string:");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput last string:");
int str2 = Convert.ToInt32(Console.ReadLine());

ChangeStringArray(myArray, str1 - 1, str2 - 1);
Show2DArray(myArray);
*/
// Задача 3: Из двумерного массива целых чисел удалить строку и столбец,
//           на пересечении которых расположен наименьший элемент.
/*
int[,] CutArray(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, x = 0; i <array.GetLength(0); i++)
        if (i != minI)
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
                if( j != minJ)
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            x++; 
        }
    return newArray;  
  
}

int[,] myArray = CreateRandom2DArray();

Show2DArray(myArray);
int[,] newArray = CutArray(myArray);
Console.WriteLine();
Show2DArray(newArray);
*/


