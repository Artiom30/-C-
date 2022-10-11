// Задача 1: Напишите программу, которая принимает на вход пятизначное 
//           число и проверяет, является ли оно палиндромом.

//           14212 -> нет
//           12821 -> да
//           23432 -> да

bool Palindrome(int num)
{
    int digit1 = num / 10000;
    int digit2 = (num / 1000) % 10;
    int digit4 = (num % 100) / 10;
    int digit5 = num % 10;

    if (digit1 + digit2 == digit4 + digit5)
        return true;
    else
        return false;
}

Console.WriteLine("Hello. I will answer whether your five-digit number is true.");
Console.WriteLine("Give me a five digit number :");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000 || num < -9999 && num > -100000)
    Console.WriteLine(Palindrome(num));
else
    Console.WriteLine("Your number is not five digits.");