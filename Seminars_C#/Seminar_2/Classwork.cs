// Задача 1.Напишите программу, которая принимает двузначное число и показывает
//          наибольшую цифру числа.

int FindBiggerDiget(int num);
{
    int result;

    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec)
        result = ed;
    else
        result = des;


    return result;
}
Console.Write("Imput two-digit number:");
int number = Convert.ToInt32(Console.ReadLine());

int BiggerDigit = FindBiggerDiget(number);
Console.WriteLine($"Bigger diget of {number} is {BiggerDigit}");