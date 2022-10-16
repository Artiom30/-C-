//Задача 1: Напишите программу, которая принимает на вход число (А) и
//          выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum = 0;

    for (int current = 1; current <= num; current++)
        sum += current; //sum =sum + current;
    return sum;    
}

Console.WriteLine("imput number :");
int a = Convert.ToInt32(Console.ReadLine());

int s = GetSum(a);
Console.WriteLine($"Sum of number from 1 to {a} is {s}");
*/

// Задача 2: Напишите программу, которая принимает на вход число и 
//           выдаёт количество цифр в числе.
/*
int Amountnum (int num)
{
    return num.ToString().Length; // num.ToString() переводит число в строку
                                  // .Lenght - команда измеряющая количество
                                  // (работает и с массивами)
}                                  

Console.WriteLine("Imput your number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of digits in a {num} is {Amountnum(num)} ");
*/

// Задача 2: Математический метод (Через While).
/*
int AmountNum(int num) 
{
    int corrent = 0;
    while(num > 0) 
    {
        num /= 10;  // num = num /10;
        corrent++;
    }
  // return num.ToString().Length;
    return corrent;
} 
Console.WriteLine("Imput your number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of digits in a {num} is {AmountNum(num)} ");
*/
//Задача 3: Напишите программу, которая принимает на вход число N и 
//           выдаёт произведение чисел от 1 до N.
/*
int Factorial(int num) 
{
  int result = 1;
  for (int i = 1; i <= num; i++) result *= i; //result *= i  result = result *i;
  return result;
}

Console.Write("Imput a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write( $"Factorial of numbers from 1 to {a} is {Factorial(a)}");
*/
//Задача 4: Напишите программу, которая выводит массив из m элементов,
//          заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)     // []  говорит о том что это массив
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("imput number of elements:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput min possinbe number:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput max possinbe number:");
int max = Convert.ToInt32(Console.ReadLine());

int[] maArray = CreateRandomArray(size, min, max);
ShowArray(maArray);
