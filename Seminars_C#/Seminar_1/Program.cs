/*
// Операторы вывода:
Console.Write("Good evening everyone!");
Console.WriteLine("hello!");
*/
// Переменные
/*
int n1 = 7 (целые значения)
double n2 = 13.56 (значения с плавающей точкой)
string name = "Artiom" (строчная переменная)
bool check = true (логическая переменная , принимающая значения либо "True" либо "Folse")
*/
/*
// "+" служит для склейки объектов передоваемых в строке(конкатенация)
int n1 = 7;
Console.Write("My number is " + n1);
*/
// Операторы ввода и конвертации. Используются для запроса данных от пользователя.
// Перед ними пишут текстовую строку для уточнения пользователю действий
/*
Console.WriteLine("imput a number :");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("your number is " + num);

WriteLine() - используется для ввода симвалов пользователем.  

Convert - используется для перевода одного вида значения в другой( String => int)

ToInt32 - в целочисленный вид.(почему именно 32 так и не понял)

То , что пользователь введёт в терминале после запроса,
программа воспринимает как строчные значения , для того чтобы 
консоль понимала что это число и нужна команда Convert.
*/




// Задача 1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Imput first number : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number : ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if(n1 == q2)
{ 
   Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Imput a number :");
int n = Convert.ToInt32(Console.ReadLine());

int current  = -n;
if(n < 0)

{
    current = n;
    n = -n;
}

while(current <= n)
{
    Console.Write(current + "");
    current++;
}
*/

// Задача 3.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("imput a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int lastdigit = n % 10;
    Console.WriteLine($"Last digit of {n} "is" + {lastdigit}");
}
else
{
    Console.WriteLine("Incorrect imput!");
}
*/