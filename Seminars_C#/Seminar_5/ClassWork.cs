// Семинар 5.
// Для решения задач будем использовать 2 метода из прошлых семинаров.

// Вывод массива в терминал.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

// Создание массива со случайными числами
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }

    return array;
}
// Метод создания массива с запросом значений от пользователя в самом массиве
// (от Павла)
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array:");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Imput a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
    // Метод построчно запрашивает каждый элемент массива. 
}

// Задача 1 :
// Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int SumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;
}

Console.WriteLine("Imput a number of elements:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

int result = SumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements" + result);
*/

// Задача 2:
// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
/*
int[] ArraySwapNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

Console.WriteLine("Add array's size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
PrintArray(array1);

array1 = ArraySwapNegative(array1);
PrintArray(array1);
*/


// Задача 3:
// Задайте массив из 12 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

/*
int SearchTwoDigitNum(int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 100 && array[i] > 9) current++;
    return current;
}

Console.WriteLine("There are twelve array elements.");
Console.WriteLine(" Set the bounds of the array ");
Console.WriteLine("from the minimum value to the maximum value.");
int size = 12;
Console.WriteLine("Imput a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
PrintArray(array1);

int result = SearchTwoDigitNum(array1);
Console.WriteLine("Number of two-digit is " + result);
*/

// Задача 4:
// Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
/*
bool YourNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
            return true;
    }
    return false;
}
Console.WriteLine("There are twenty random numbers.");
int size = 20;
int min =-100;
int max = 100;
Console.WriteLine("Enter a number and I'll tell you if your number is in this array or not...");
int num = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
PrintArray(array1);
if (YourNumber(array1, num))
    Console.WriteLine("Your number is in the array:");
else
    Console.WriteLine("There is not number in the array. ");
// какая бесполезная программа...
*/





