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

/*
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
*/

// Задача 3: Напишите программу, которая принимает на вход 
//           цифру, обозначающую день недели, и проверяет, является 
//           ли этот день выходным.
//           6 -> да
//           7 -> да
//           1 -> нет

/*
bool DayWeek(int num)
{
    if (num < 6)
        return false;
    else
        return true;
}

Console.WriteLine("Hello . I'm a weekend getter.");
Console.WriteLine("If today is the weekend, I'll say it's true...");
Console.WriteLine("If it's a weekday, I'll say - false...");
Console.WriteLine("Enter a number corresponding to the day of the week from 1 to 7 :");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
    Console.WriteLine(DayWeek(number));
else
    Console.WriteLine("You have the wrong week =)...");
*/