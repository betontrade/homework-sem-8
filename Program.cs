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
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// ответ math profi (искать принцип произведения матриц)




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся !!! двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// лучше вывод по слоям

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// количество строк и столбцов произвольное

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


