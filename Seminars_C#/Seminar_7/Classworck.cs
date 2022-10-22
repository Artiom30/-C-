// Семинар 7: Двумерные массивы.

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными 
//           целыми числами.
/*
// m - количество строк
// n - количество столбцов.
// Метод возвращает двумерный массив целочисленных значений int[,].
//     Аргументы к методу будут запрошены у пользователя напрямую из метода.
// Для создания массива нужно "из вне" 4 переменных: количество строк, количество
// столбцов , минимальное и максимальное значения чисел в массиве.
//     В методе инициализировать новый массив с размерами [rows,columns]([m,n]).
// C помощью вложенного цикла (цикла в цикле) заполнить массив генератором случайных 
// чисел.
//     От того в каком цикле , (внешнем или внутреннем) будет , в условии, записано rows 
// или columns будет зависить изначальное обращение к столбцам или строкам.
// Сдесь построчно.



// Метод для создания двумерного массива со случайными значениями.
*/

// int[,] CreateRandom2DArray()
{
    Console.WriteLine("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}


// Используем тим метода void. Принимает в себя двумерный int[,] массив.
//     Так же используется вложеный цикл. Но для обращения к нужному аргументу массива
// используется команда GetLength() - измеряет количество . 
// К примеру int[0,1] array
// int [GetLength(0),GetLength(1)] array.
//     Для разделения строк при выводе в терминал в конце работы внутреннего цикла
// Добавляется пустая строка.

// Метод для вывода двумерного массива в терминал.

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }


// int [,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);


/*
// Задача 2.Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//          по формуле: Aij = i+j. Выведите полученный массив на экран.

//     В задаче требуется чтобы в каждом его элементе была сумма чисел его "адреса" индекса.
// Метод будет выдавать массив ,а аргументы ( m ,n ) будут запрошены прямиком из метода.
//     Используя вложеный цикл во внутренней его части в каждый текущий элемент будет
// записана сумма цифр его текущего "адреса". 
//     Результат в отдельную переменную а переменную в метод "Show2DArray".

int[,] SumIndex2DArray()
{
    Console.WriteLine("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i + j;
    return array;
}

int[,] resultArray = SumIndex2DArray();
Show2DArray(resultArray);
*/

/*
// Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//           и замените эти элементы на их квадраты. 

// Метод void. Будет брать в себя аргумент ввиде int двумерног массива.
//     Для того чтобы не перебирать все элементы массива в цикле инкрименты установим 
// как i += 2 и j += 2. так как по условию задачи нужны элементы с чётными позициями.
//     Это позволит укоротить работу программы. 
// И содержимое каждого текущего элемента перемножим на самого себя.

void HonestEventIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];        
}

int[,] array = CreateRandom2DArray();
Show2DArray(array);
Console.WriteLine();
HonestEventIndex(array);
Show2DArray(array);
*/

/*
// Задача 4.Задайте двумерный массив. Найдите сумму элементов, находящихся на
//          главной диагонали (с индексами (0,0); (1;1) и т.д.)

//     Главная диагональ находится в матрице чисел , каторая состоит из одиногового
// количества строк и столбцов, и проходит из верхнего левого угла "матрицы" в нижний
// правый. Соответственно индексы элементов позиций в массиве будут равны.
// Соответствено для решения задачи нужно 3 метода:
// 1. Создаст "матрицу" . В ней количество столбцов и строк будут равны.
// 2. Покажет его в терминале.
// 3. Вычислит сумму элементов массива. Метод int , вернёт число, а аргументами возьмёт
// двумерный массив int[,].
//     Для того чтобы пройти только лишь по диагонали в матрице понадобится только 
// один цикл for . Запишу двойное условие в цикле ,с помощью команды GetLength(),
// в катором будет проверяться и строка и столбец при одном и том же инжексе.
// Текущее значение индекса будет складываться с предыдущим и записываться в отдельную 
// переменную. Переменная - результат метода. Её же и выведу на экран
    
int SumElementOfDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
          result +=array[i,i];  
    return result;
}
int[,] CreateRandomMarix()
{
    Console.WriteLine("Imput a Matrix size: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
    Console.WriteLine("Imput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int [,] array = CreateRandomMarix();
Show2DArray(array);
Console.WriteLine(SumElementOfDiagonal(array));
*/


