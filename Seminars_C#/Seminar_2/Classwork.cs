// Задача 1.Напишите программу, которая принимает двузначное число и показывает
//          наибольшую цифру числа.
/*
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
*/

//  Задача 2.Напишите программу, которая выводит случайное трёхзначное
//           число и удаляет вторую цифру этого числа.

int DeleteSecondNum(int num)
{
    int result;

    int ed = num % 10;
    int sot = num / 10;

    result = sot*10 + ed; 
    return result;  
}

int number = new Random().Next(100,999);
int number = new num; 

int twoBigitNumber = DeleteSecondNumber(number);
Console.WriteLine($"a three-digit {number} without a second cipher {twoBigitNumber}
");



//  Задача 3. Напишите программу, которая принимает на вход число n и проверяет, кратно ли 
//            оно одновременно a и b(целочисленные делители, также задаются пользователем).




