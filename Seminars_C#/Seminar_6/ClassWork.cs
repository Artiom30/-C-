// Семинар 6:
int[] CreateRandomArray()
{
    Console.WriteLine("imput number of elements:");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("imput min possinbe number:");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("imput max possinbe number:");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// Демонстрация отличия передачи значения переменной напрямую или в методе.

/*
void ShowNumber(int a) // для значения переменной num выделяется память по новой.
// Таким образом получаются две разные переменный и одним и тем же значением.
{
    a += 10; // А изменение переменной "а" не приводит к изменению переменной num.
    Console.WriteLine(a);
}

int num = 5;
ShowNumber(num);
Console.WriteLine(num);
*/
// Для обычных переменных это не занимает много памяти , для массивов происходит иначе.
// Так как массив может занимать гораздо больше памяти , вместо создания нового массива
// в методе, при принятии его как аргумент , метод воспринимает его как ссылку на 
// первоисточник массива, и все изменения безвозвратно будут происходить и в оригинальном.
/*
void ChangeArray(int[] array)
{// В этом случае используется буквально тот же массив каторый поступил в аргументы.
    array[0] += 10; 
}
int[] myArray = CreateRandomArray();// Создаст массив
ShowArray(myArray); // Покажет созданный массив.
ChangeArray(myArray);// Изменит массив.
ShowArray(myArray);// Покажет изменённый массив.
// Теперь обратиться к изначальному myArray нет возможности.
*/
/*
// Чтобы не трогать первоисточный массив нужно перезаписать его в самом методе , 
// выделив для него столько же памяти сколько было изначально (new int[array.Length]).
int[] ChangeArray(int[] array)
{
    int newArray = new int[array.Length];
    newArray[0] = array[0] + 10;
    for (int i = 1; i < array.Length; i++) //i = 1; - так как  i[0] уже замисали
        newArray[i] = array[i];
    return newArray;// Возвращает уже новый массив не трогая старый.
}
int[] myArray = CreateRandomArray();
ShowArray(myArray); 
int[] array2 = ChangeArray(myArray);
ShowArray(array2);
ShowArray(myArray);
// Теперь первоисточный myArray остился не тронутым
*/
/*
// Задача 1: Напишите программу, которая перевернёт одномерный массив
//           (последний элемент будет на первом месте, а первый 
//           - на последнем и т.д.)

// Так как нужно изменить именно первоисточник (массив) тип метода для реализации
// программы выберем void, а аргументом будет массив из целочисленных значений.

// Сам метод реализуем с помощью оператора циклирования For ,но в нём будет 2 рабочих
// переменных (рабочих переменных в цикле можно задавать сколько угодно, минус в том
// что строка в коде становится слишком длинной). переменная i - ,будет отвечать за 
// первую половину массива , а переменна j за вторую. Начинать перенос будем с первой 
// и последней позиций одновременно постепенно сходясь к середине пока (i < j). Объявим 
// временную переменную для переноса содержимого  .

void ChangeArray(int[] array)
{     // i и j инициализируем одновременно.
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
ChangeArray(myArray);
ShowArray(myArray);

*/
/*
// Задача 2: Напишите программу, которая принимает на вход три числа и проверяет, 
//           может ли существовать треугольник с сторонами такой длины.
// (способы реалицации переменных и методов типа bool).

// Треугольник возможен в том случае если каждая ЗАДАННАЯ сторона треугольника будет 
// строго меньше суммы двух других ЗАДАННЫХ сторон.
// если:
// a + b > c
// a + c > b   <= Треугольник ABC возможен.
// b + c > a

// Так как метод типа bool (имеет 2 варианта возврата положительный и отрицательный)
// то и само условие , записанное как возвращаемое, если положительное - вернёт
// положительный ответ и отрацательное - вернёт отрицательный.

bool Exist(int a, int b, int c)
{ 
    return a + b > c && a + c > b && b + c > a;

    // bool result = a + b > c && a + c > b && b + c > a;
    // return result;
    
    // if (a + b > c && a + c > b && b + c > a) return true;
    // else return false;
}
Console.WriteLine("imput a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput c:");
int c = Convert.ToInt32(Console.ReadLine());

bool exist = Exist(a,b,c);
if(exist) Console.Write("Triangle possible.");
else Console.Write("Triangle not possible");
// Так же как и в методе , при выводе данных в условии оператора ветвления if используем
// результат метода записаный в переменную такого же типа и соответственно если 
// он положительный то ветвление будет осуществляться по положительной "ветке",
// а отрицательный по отрицательной.
*/

/*
// Задача 3: Напишите программу, которая будет создавать копию заданного массива с
//           помощью поэлементного копирования.

int[] Copy(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    return copyArray;
}

int[] array = CreateRandomArray();
ShowArray(array);
ShowArray(Copy(array));
array[1] = 8; // для демонстрации того что исхожный массив не тронут.
ShowArray(array);
*/

/*
// Задача 4:  Не используя рекурсию, выведите первые N чисел Фибоначчи.
//                       Первые два числа Фибоначчи: a и b.
//                       Первыйе 2 числа должны быть определены!

// Числа Фибоначи - это числовая последовательность , каторая формируется по принципу: 
// каждое новое число является суммой двух предидущих. 
// Примеры : 0 1 1 2 3 5 8. 1 = 0 + 1, 2 = 1 + 1, 3 = 1 + 2, 5 = 2 + 3, 8 = 3 + 5.
//           0 3 3 6 9 15.  3 = 0 + 3, 6 = 3 + 3, 9 = 3 + 6, 15 = 9 + 6.
//           5 7 9 16 25.   9 = 5 +7, 16 = 7 + 9, 25 = 9 + 16.

// Создадим в методе массив в нём первые два элемента задаст пользователь , так же как и
// размер массива , каторый будет равен числу N. Затем последовательно , начиная с 3-го
// элемента массива  i = 2 , через цикол for будем заполнять массив до числа N по формуле
// f(n)=f(n-2)+f(n-1). Метод будет забирать аргументы напрямую от пользователя а выдовать
// int[] массив.
          
int[] Fibonachi()
{
    Console.WriteLine("Enter the number of fibonacci N:");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    Console.WriteLine("First fibonacci number?");
    array[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Secomd fibonacci number?");
    array[1] = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i < array.Length; i++)
        array[i] = array[i - 2] + array[i - 1];
    return array;
}

int[] fibonachiRow = Fibonachi();
Console.WriteLine("Your Fibonacci Series :");
ShowArray(fibonachiRow);
*/




