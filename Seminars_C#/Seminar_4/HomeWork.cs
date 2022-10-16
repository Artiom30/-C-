// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
//           возводит число A в натуральную степень B.
//           3, 5 -> 243 (3⁵)
//           2, 4 -> 16


/*
int AtoB(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result *= a;
    return result;
}
Console.WriteLine(" Imput two numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"I will raise {a} to the power of {b}");
Console.WriteLine(AtoB(a,b));
// double atob = Math.Pow(a,b);
// Console.WriteLine(atob);
*/

/*
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт
//            сумму цифр в числе.
//            452 -> 11
//            82 -> 10
//            9012 -> 12

int SumOfDigits(int num)
{
    int size = num.ToString().Length;
    int current = num;
    int result = 0;
    for (int i = 1; i <= size; i++)
    {
        result = current % 10 + result;
        current /=10;
    }    
    return result;
}

Console.WriteLine("Imput your number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of digits of {num} is {SumOfDigits(num)}");
*/
/*
// Задача 3: Напишите программу, которая задаёт массив из m 
//            элементов и выводит их на экран.
//            m = 5 -> [1, 2, 5, 7, 19]
//            m = 3 -> [6, 1, 33]

void YourSizeArray(int m)
{
    int[] array = new int[m];
    int i = 0;
    Console.Write($"m = {m} ->[");
    while (i < array.Length - 1)
    {
        array[i] = new Random().Next(0, 1000);
        Console.Write(array[i] + " ,");
        i++;
    }
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i]);
    Console.Write("]");
}
Console.WriteLine("I am a magician. I will turn your number into an array.");
Console.WriteLine("Imput number - m:");
int m = Convert.ToInt32(Console.ReadLine());
YourSizeArray(m);
*/