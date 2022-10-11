// Задача 1: Напишите программу, которая принимает на вход пятизначное 
//           число и проверяет, является ли оно палиндромом.

//           14212 -> нет
//           12821 -> да
//           23432 -> да
/*
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
*/

// Задача 2: Напишите программу, которая принимает на вход координаты 
//           двух точек и находит расстояние между ними в 3D пространстве.
//                    A (3,6,8); B (2,1,-7), -> 15.84
//                    A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 3: Напишите программу, которая принимает
//           на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//           3 -> 1, 8, 27
//           5 -> 1, 8, 27, 64, 125

void NumberCube(int num)
{
    int count =1;
    for (count = 1; count <= num; count++)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
    }
}
Console.WriteLine("Imput yuor namber: ");
int number = Convert.ToInt32(Console.ReadLine());
NumberCube(number);