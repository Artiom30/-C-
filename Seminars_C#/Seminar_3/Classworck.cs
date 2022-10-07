// Math.Paw(a,b) - это математическая формула вычисления 
//                 квадрата числа "а" в степени "b".
//                 (работает для переменных типа duoble).
// Math.Sqrt(a)  - это математическа формула вычиления из
//                 под корня числа "а".
//                 (работает для переменных типа duoble).
// Особенности метода "void" :
//         - тип "void" пишется в названии метода.
//         - внутри метода пишется обращение к консоли (типа "Write").
//         - при обращении сразу выдаёт результат в терминал.


// Задача 1 : Напишите программу, которая принимает на вход координаты
//          точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
//          плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    int num = 0;

    if (x > 0 && y > 0) num = 1;
    if (x < 0 && y > 0) num = 2;
    if (x < 0 && y < 0) num = 3;
    if (x > 0 && y < 0) num = 4;

    return num;
}
Console.WriteLine("imput x - coordinate :");
double x = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("imput y - coordinate :");
double y = Convert.ToDouble (Console.ReadLine());

int quartNum = FindQuart(x,y);
Console.WriteLine($"The point A{x},{y} is {quartNum}quart.");
*/

// Задача 2: Напишите программу, которая принимает на вход координаты
//           двух точек и находит расстояние между ними в 2D пространстве.

/*

double FindDistanse(double xa, double ya, double xb, double yb)
{
    double ac = xb - xa;
    double bc = yb - ya;
    double ab = ac * ac + bc * bc;
    return Math.Sqrt(ab);
}

Console.Write("Imput X(a) - coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput Y(a) - coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput X(b) - coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput Y(b) - coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());

double ab = FindDistanse(xa, ya, xb, yb);
Console.WriteLine("The distance between points = " + ab);

*/

// Задача 3 : Напишите программу, которая принимает на вход число (N)
//            и выдаёт ряд квадратов чисел от 1 до N.
/*
void SowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count,2);
        Console.Write(n + " ");
        count++;
    }
}
Console.WriteLine("Imput yuor namber: ");
int number = Convert.ToInt32(Console.ReadLine());
SowNumbers(number);
*/