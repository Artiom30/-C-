// Задача 1.Напишите программу, которая принимает двузначное число 
//          и показывает наибольшую цифру числа.
/*
int FindBiggerDiget(int num)
{
    int result;
    if (num < 10 || num >= 100)
        return 0;
    else
    {
        int ed = num % 10;
        int dec = num / 10;

        if (ed > dec)
        {
            result = ed;
        }
        else
        {
            result = dec;
        }
        return result;
        }
}
    Console.Write("Imput two-digit number:");
    int number = Convert.ToInt32(Console.ReadLine());

    int BiggerDigit = FindBiggerDiget(number);
    Console.WriteLine($"Bigger diget of {number} is {BiggerDigit}");
*/

//  Задача 2.Напишите программу, которая выводит случайное трёхзначное
//           число и удаляет вторую цифру этого числа.
/*
int DelSecDig(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int result = sot*10 + ed; 
    return result;  
}

int RandomNum = new Random().Next(100, 1000);
Console.WriteLine(RandomNum);
Console.WriteLine(DelSecDig(RandomNum));
*/

//  Задача 3. Напишите программу, которая принимает на вход число n и 
//            проверяет, кратно ли 
//            оно одновременно a и b(целочисленные делители, также 
//            задаются пользователем).
/*
bool Multiple(int n, int a, int b)
{
    int remA = n % a;
    int remB = n % b;
    int resultRem = remA + remB;

    if (resultRem == 0) return true;
    else
        return false;
}

Console.WriteLine("If the number N is divisible by your numbers, I'll say it's true. ");
Console.WriteLine("Enter the number to be divided:Imput number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first number to divide : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number to divide : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiple(n, a, b));
*/