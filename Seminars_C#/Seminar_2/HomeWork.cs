// // Задача 1: Напишите программу, которая принимает на вход трёхзначное 
//              число и на выходе показывает вторую цифру этого числа.

//              456 -> 5
//              782 -> 8
//              918 -> 1

int SecondNumber(int num)
{
    int result = 0;

    if (num < 100 || num > 999)
        return result;
    else
    {
        int delEd = num / 10;
        int delSot = delEd % 10;
        result = delSot;
    }    
    return result;
}

Console.Write("Imput a three-digit number :");
int res = Convert.ToInt32(Console.ReadLine());

int Result = SecondNumber(res);

if (Result == 0)
   Console.WriteLine("Your number does not match the condition of the problem.");
else
Console.WriteLine($"Second digit from the number:{res} is {Result}");