// Семинар 9
// Тема: Рекурсия. Рекурсивные методы.

// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные 
//           числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
  //Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
    Console.Write(n + " ");
}

ShowNums(5); // 1 2 3 4 5 Обращение к методу напрямую.
*/

// Задача 2: Напишите программу, которая будет принимать на вход число и возвращать 
//           сумму его цифр.
/*
int SumOfDigits(int n)
{
    if (n != 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(1)); // 10
*/
// Задача 3:  Задайте значения M и N. Напишите программу, которая выведет все
//            натуральные числа в промежутке от M до N.
/*
void NumberMtoN(int m, int n)
{
    if (m == n)
        Console.Write(n + " ");
    if (n < m)
    {
        NumberMtoN(m - 1, n);
        Console.Write(m + " ");
    }
    if (n > m)
    {
        NumberMtoN(m, n - 1);
        Console.Write(n + " ");
    }
}

NumberMtoN(5, 1);  // 1 2 3 4 5
*/
// Задача 4 : Напишите программу, которая на вход принимает два числа A и B,
//            и возводит число А в целую степень B.
/*
// A в -B =  1/ A  B раз.
double ADegreeB(double a, double b)
{
    if (b < 0)
    {
        return 1 / a * ADegreeB(a, b + 1);
    }
    if (b > 0)
    {
        return a * ADegreeB(a, b - 1);
    }
    return 1;
}

Console.WriteLine(ADegreeB(-2, -3)); // - 0,125
*/