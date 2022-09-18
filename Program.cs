//1

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
// 8 4 4 2
// по строкам!!!!!!!

/* Решение внутри

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           array[i, j] = new Random().Next(minValue, maxValue);
       }
   }
   return array;
}

void ShowArray(int[,] arrayForShow)
{
   for (int i = 0; i < arrayForShow.GetLength(0); i++)
   {
       for (int j = 0; j < arrayForShow.GetLength(1); j++)
       {
           Console.Write("{0, 3}", arrayForShow[i, j] + " ");
       }
       Console.WriteLine();
   }
   Console.WriteLine();
}

int[,] SortArray(int[,] arrayForSort)
{
   int temp = 0;
   for (int i = 0; i < arrayForSort.GetLength(0); i++)
   {
       for (int j = 1; j < (arrayForSort.GetLength(1) -1); j++)
       {              // 2    (1)           // 1   (9)
           for (int l = 1; l < arrayForSort.GetLength(1); l++)
           {
               if (arrayForSort[i, l] < arrayForSort[i, l - 1])
               {
                   temp = arrayForSort[i, l - 1];
                   arrayForSort[(i), l - 1] = arrayForSort[i, l];
                   arrayForSort[(i), (l)] = temp;
               }
           }
       }
   }
   return arrayForSort;
}



Console.Write("Пожалуйста введите количество строк в массиве: ");
int rowsCreate = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите количество столбцов в массиве: ");
int columnsCreate = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите минимальное значение числа в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите максимальное значение числа в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateArray(rowsCreate, columnsCreate, minValue, maxValue);
ShowArray(firstArray);

int[,] arrayAfterSort = SortArray(firstArray);

Console.WriteLine("Отсортированный массив равен: ");
Console.WriteLine();

ShowArray(arrayAfterSort);

*/

// 2
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

// 1 4 7 2

// 5 9 2 3

//8 4 2 4

// 5 2 6 7

// вывести номер строки и сумму строки (считаем с нуля)

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* Решение внутри

int[,] CreateArray(int rowsAndColumns, int minValue, int maxValue)
{
    int[,] array = new int[rowsAndColumns, rowsAndColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void ShowArray(int[,] arrayForShow)
{
    for (int i = 0; i < arrayForShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForShow.GetLength(1); j++)
        {
            Console.Write("{0, 4}", arrayForShow[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int IndexOfMin (int [,] array)
{
    Console.WriteLine();
    int maxSummCount = 0;
    int maxSummFinal = 0;
    int indexRows =0;
    int l =0 ;

    for (int m = 0; m < array.GetLength(1); m++)
        {
            maxSummFinal = maxSummFinal + array[0, m];
        }
        
    Console.WriteLine("Cумма в строке 0 равняется: " + maxSummFinal);

    for (l = 1; l < array.GetLength(0); l++)
    {
        for (int  j = 0; j < array.GetLength(1); j++)
        {
            maxSummCount = maxSummCount + array[l, j];
        }

        Console.WriteLine("Cумма в строке "+ l + " равняется: " + maxSummCount);
        if (maxSummCount < maxSummFinal)
        {
            indexRows = l;
            maxSummFinal = maxSummCount;
            maxSummCount =0;
        }
        maxSummCount = 0 ;
    }
    Console.WriteLine();
    return indexRows;
}



Console.Write("Пожалуйста введите количество строк и столбцов в массиве: ");
int rowsAndColumnsFinal = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите минимальное значение числа в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите максимальное значение числа в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateArray(rowsAndColumnsFinal, minValue, maxValue);

ShowArray(firstArray);

int indexOfMinRowsSumm = IndexOfMin(firstArray);

Console.WriteLine("Индекс строки с наименьшей суммой чисел равен: " + indexOfMinRowsSumm);

*/


// 3
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/* Решение внутри

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           array[i, j] = new Random().Next(minValue, maxValue);
       }
   }
   return array;
}

void ShowArray(int[,] arrayForShow)
{
   for (int i = 0; i < arrayForShow.GetLength(0); i++)
   {
       for (int j = 0; j < arrayForShow.GetLength(1); j++)
       {
           Console.Write("{0, 4}", arrayForShow[i, j] + " ");
       }
       Console.WriteLine();
   }
}

int[,] CalcMatrix(int[,] first, int[,] second)
{
   int[,] calcArray = new int[first.GetLength(0), second.GetLength(1)];
   for (int i = 0; i < first.GetLength(0); i++)
   {
       for (int j = 0; j < second.GetLength(1); j++)
       {
           for (int l = 0; l < second.GetLength(0); l++)
           {
               calcArray[i, j] = calcArray[i, j] + first[i, l] * second[l, j];
           }
       }
   }
   return calcArray;
}

//______________________________Создание массива 1_____________________
Console.Write("Пожалуйста введите количество строк в массиве №1: ");
int rowsCreate = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите количество столбцов в массиве №1: ");
int columnsCreate = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите минимальное значение числа в массиве №1: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите максимальное значение числа в массиве №1: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateArray(rowsCreate, columnsCreate, minValue, maxValue);

//____________________________Создание массива 2______________________________

Console.Write("Пожалуйста введите количество строк в массиве №2: ");
int rowsCreate2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите количество столбцов в массиве №2: ");
int columnsCreate2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите минимальное значение числа в массиве №2: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите максимальное значение числа в массиве №2: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[,] secondArray = CreateArray(rowsCreate2, columnsCreate2, minValue2, maxValue2);


Console.WriteLine("Даны две матрицы:");
ShowArray(firstArray);
Console.WriteLine("и:");
ShowArray(secondArray);

if (firstArray.GetLength(1) != secondArray.GetLength(0))
{
   Console.WriteLine("Невозможно посчитать произведение матриц, так как количество столбцов ");
   Console.WriteLine("первой матрицы не равно количеству строк во второй матрице");
}
else
{
   Console.WriteLine("их произведение равно:");
   int[,] CalcFinalMatrix = CalcMatrix(firstArray, secondArray);
   ShowArray(CalcFinalMatrix);
   Console.WriteLine();
}

*/


// 4

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся !!! двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// лучше вывод по слоям

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

 /* Решение внутри

int[,,] CreateArray(int rows, int columns, int rowsSecond, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, rowsSecond];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return array;
}

void ShowArray(int[,,] arrayForShow)
{
    for (int i = 0; i < arrayForShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForShow.GetLength(1); j++)
        {
            for (int l = 0; l < arrayForShow.GetLength(2); l++)
            {
                Console.Write("{0, 20}", arrayForShow[i, j, l] +$" ({i}, {j}, {l}) ");
            }

        }
        Console.WriteLine();
    }
}

int[,,] AllNumber(int[,,] arrayForShow)
{
    for (int i = 0; i < arrayForShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForShow.GetLength(1); j++)
        {
            for (int l = 0; l < arrayForShow.GetLength(2); l++)
            {
                IndexArray(arrayForShow[i, j, l], arrayForShow, i, j, l); // поменяли числа
            }
        }
    }
    return arrayForShow;
}

int[,,] IndexArray(int num, int[,,] array, int m, int n, int p)
{
    int[,,] arrayThird = new int[1, 1, 1];
    
    int count = array[0, 0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                if (count < array[i, j, l])
                {
                    count= array[i, j , l];
                }
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                while ((array[i, j, l] == array [m, n, p]) && ((i != m) || (j != n) || (l!=p))  )
                {
                    count++;
                    array[i, j, l] = count;  
                }
            }
        }
    }
    
    arrayThird = array;

    return arrayThird;
}


int[,,] arrayFirst = CreateArray(2, 2, 2, 1, 90);
int [,,] arraySecond = AllNumber(arrayFirst);
ShowArray(arraySecond);


  */


// 5 
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// количество строк и столбцов произвольное

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Попытка решить задачу 4, заменяя повторяющиеся элементы методом new Random().Next(min, max)

// Вопрос: Почему, при такой реализации, все равно остаются повторяющиеся числа? Не могу найти ответ,
// в чем моя ошибка?

/* Решение внутри

int[,,] CreateArray(int rows, int columns, int rowsSecond, int minValue, int maxValue)
{
   int[,,] array = new int[rows, columns, rowsSecond];
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           for (int l = 0; l < array.GetLength(2); l++)
           {
               array[i, j, l] = new Random().Next(minValue, maxValue);

           }
       }
   }
   return array;
}

void ShowArray(int[,,] arrayForShow)
{
   for (int i = 0; i < arrayForShow.GetLength(0); i++)
   {
       for (int j = 0; j < arrayForShow.GetLength(1); j++)
       {
           for (int l = 0; l < arrayForShow.GetLength(2); l++)
           {
               Console.Write("{0, 20}", arrayForShow[i, j, l] +$" ({i}, {j}, {l}) ");
           }

       }
       Console.WriteLine();
   }
}

int[,,] AllNumber(int[,,] arrayForShow)
{
   for (int i = 0; i < arrayForShow.GetLength(0); i++)
   {
       for (int j = 0; j < arrayForShow.GetLength(1); j++)
       {
           for (int l = 0; l < arrayForShow.GetLength(2); l++)
           {
               IndexArray(arrayForShow[i, j, l], arrayForShow, i, j, l); // поменяли числа
           }
       }
   }
   return arrayForShow;
}

int[,,] IndexArray(int num, int[,,] array, int m, int n, int p)
{
   int[,,] arrayThird = new int[1, 1, 1];


   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           for (int l = 0; l < array.GetLength(2); l++)
           {
               while ((array[i, j, l] == array [m, n, p]) && ((i != m) || (j != n) || (l!=p))  )
               {
                   array[i, j, l] = new Random().Next(1, 10);  
               }
           }
       }
   }

   arrayThird = array;

   return arrayThird;
}


int[,,] arrayFirst = CreateArray(2, 2, 2, 1, 10);
int [,,] arraySecond = AllNumber(arrayFirst);
ShowArray(arraySecond);

*/



// Вторая попытка решить задачу 4.

// Вопрос , такая же ситуация, при попытке создания массива с неповторяющимися числами, все равно попадаются 
// одинаковые. 

/* Решение внутри

int[,,] CreateArray(int rows, int columns, int rowsSecond, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, rowsSecond];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = new Random().Next(minValue, maxValue);
                count = array[i, j, l];

                for (int m = 0; m <  array.GetLength(0); m++)
                {
                    for (int n = 0 ; n < array.GetLength(1); n++)
                    {
                        for (int p = 0; p < array.GetLength(2) ; p++)
                        {
                        
                            while ((array[i, j, l] == array [m, n, p]) && (i!=m | j!=n | l!=p))
                            {
                                Console.WriteLine("Зашли в наш цикл == переменная равна: == " +array[i, j, l] );
                                array[i, j, l] = new Random().Next(minValue, maxValue);
                                Console.WriteLine("Зашли в наш цикл!  после изменения переменная равна===" + array[i, j, l]);
                            }
                            
                            
                        }
                    }
                }
                count = 0;



            }
        }
    }
    return array;
}

void ShowArray(int[,,] arrayForShow)
{
    for (int i = 0; i < arrayForShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForShow.GetLength(1); j++)
        {
            for (int l = 0; l < arrayForShow.GetLength(2); l++)
            {
                Console.Write("{0, 5}", arrayForShow[i, j, l]);
            }

        }
        Console.WriteLine();
    }
}

int [,,] arrayFifth = CreateArray(2, 2, 2, 1, 10);

ShowArray(arrayFifth);

*/