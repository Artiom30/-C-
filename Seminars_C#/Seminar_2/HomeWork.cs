// // Задача 1: Напишите программу, которая принимает на вход трёхзначное 
//              число и на выходе показывает вторую цифру этого числа.

//              456 -> 5
//              782 -> 8
//              918 -> 1
/*
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
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного
//            числа или сообщает, что третьей цифры нет.

//            645 -> 5
//            78 -> третьей цифры нет
//            32679 -> 6

int TreeDigNum(int num)
{
    int result = 11;
    int current = num;

    if (current > 99)
    {
        while (current > 1000) 
            current = current / 10;
        {
            result = current % 10;
            return result;
        }
    }
    else
        return result;
}

Console.WriteLine("Imput your digit: ");
double num = Convert.ToDouble(Console.ReadLine());
int Num = Convert.ToInt32(Math.Round(num,0));     // это конечно хорошо, но какого оно округляет 99,6 до 100...

int result = TreeDigNum(Num);

if (result == 11)
    Console.WriteLine("Your number does not have a third digit.");
else
    Console.WriteLine($"The third digit of your number is {result}.");