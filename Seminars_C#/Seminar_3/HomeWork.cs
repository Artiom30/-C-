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

// // Задача 1: Через "строки":

// bool Palindrome(string num)
// {
//     int length = num.Length;
//     string reverceNum = String.Empty;
//     for (int i = length-1; i >= 0; i--)
//         reverceNum = reverceNum + num[i];
//     if (num == reverceNum) return true;
//     else return false;    
// }

// Console.WriteLine("Hello. I will check if you have a palendrome or not.");
// Console.WriteLine("Write your palendrome :");
// string num = Console.ReadLine();

// Console.WriteLine(Palindrome(num) + ", it's a palendrome.");


// Задача 2: Напишите программу, которая принимает на вход координаты 
//           двух точек и находит расстояние между ними в 3D пространстве.
//                    A (3,6,8); B (2,1,-7), -> 15.84
//                    A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double FindDistanse(double xa, double ya, double za,
                    double xb, double yb, double zb)
{
    double ac = xb - xa;
    double bc = yb - ya;
    double zc = zb - za;

    double ab = ac * ac + bc * bc + zc * zc;
    return Math.Sqrt(ab);
}

Console.Write("Imput X(a) - coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput Y(a) - coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput Z(a) - coordinate: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput X(b) - coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput Y(b) - coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput Z(b) - coordinate: ");
double zb = Convert.ToDouble(Console.ReadLine());

double ab = FindDistanse(xa, ya, za, xb, yb, zb);
double AB = Math.Round(ab, 2);
Console.WriteLine("The distance between points = " + AB);
// Формулу содрал из гугла а как она образована не понял.
*/
// Задача 3: Напишите программу, которая принимает
//           на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//           3 -> 1, 8, 27
//           5 -> 1, 8, 27, 64, 125

/*
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
*/