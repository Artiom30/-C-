// Задача 1: Задайте значение N. Напишите программу, которая выведет все 
//           натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//           N = 5 -> "5, 4, 3, 2, 1"
//           N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void DescendingRow(int n)
{
    Console.Write(n + " ");
    if (n > 1) DescendingRow(n - 1);
}
Console.WriteLine(" Imput your Natural number :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"A series of numbers in descending order from {n} to 1:");
DescendingRow(n);


// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//           натуральных элементов в промежутке от M до N.
//           M = 1; N = 15 -> 120
//           M = 4; N = 8. -> 30

// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//           Даны два неотрицательных числа m и n.
//           m = 2, n = 3 -> A(m,n) = 9
//           m = 3, n = 2 -> A(m,n) = 29