// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//           сколько чисел больше 0 ввёл пользователь.
//           0, 7, 8, -2, -2 -> 2
//           1, -7, 567, 89, 223-> 4

/*
void CounterNumbers()
{
    Console.WriteLine("Enter the numbers, and I will count how many are positive.");
    Console.WriteLine("How many numbers will we check?");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    Console.WriteLine("Number of positive numbers = " + count);
}

CounterNumbers();
*/

/*
// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//           заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,
//           k1, b2 и k2 задаются пользователем.
//           b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1
// y = k2 * x + b2

// y - y = k1 * x + b1 - k2 * x - b2

// 0 = k1 * x - k2 * x + b1 - b2

// -k1 * x + k2 * x = b1 - b2

// ( -k1 + k2) * x = b1 - b2

// x = (b1 - b2) / (-k1 + k2)   -   x = (2 - 4)/(-5 + 9) = -0,5

// y = k1 * ((b1 - b2) / (-k1 + k2)) + b1    -   y = 5 * ((2 - 4)/(-5 + 9)) + 2 = -0,5
//             или                                      одинаково
// y = k2 * ((b1 - b2) / (-k1 + k2)) + b2    -   y = 9 * ((2 - 4)/(-5 + 9)) + 4 = -0,5
// Так и подставлю в программу.

void IntersectionCoordinates(double b1, double b2,double k1, double k2)
{
    double x = (b1 - b2) / (-k1 + k2);
    double y = k1 * ((b1 - b2) / (-k1 + k2)) + b1;
    Console.WriteLine($"Coordinates of intersection points in a 2D plane is ({Math.Round(x,1)} , {Math.Round(y,1)})");
}

Console.WriteLine("y = k1 * x + b1 and y = k2 * x + b2");
Console.WriteLine("These are the equations of lines in 2D space.");
Console.WriteLine("Enter the values of the variables and I will find the coordinates of the points.");
Console.WriteLine("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

IntersectionCoordinates(b1,b2,k1,k2);
*/

// Решить то решил. А что за b1,b2,k1,k2 и откуда они возникают,
// и где ваобще это можно использовать... 


