
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] DoubleArray(int rows, int cols, double min, double max)
// {
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
//         }
//            }
//      return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter numb of min elem: ");
// double min = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter numb of max elem: ");
// double max = Convert.ToDouble(Console.ReadLine());

// double[,] array = DoubleArray(m, n, min, max);
// Show2dArray(array);



// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] New2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindPosition(int[,] array)
// {
//     Console.WriteLine("Введите позиции элемента в строке(k):   ");
//     int k = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите позиции элемента в столбце(l):   ");
//     int l = Convert.ToInt32(Console.ReadLine());
//     if (k >= array.GetLength(0) || l >= array.GetLength(1)) Console.WriteLine("Такой позиции нет в массиве.");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (k == i && l == j)
//             {
//                 Console.WriteLine($"Значение элемента в массиве равно: {array[i, j]} ");
//             }

//         }
//     }
// }
// Console.WriteLine("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = New2dArray(m, n, min, max);

// ShowArray(array);

// FindPosition(array);



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] New2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FindSrednArifm(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            {
                sum = sum + array[i, j];
            }
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 1)}  ");
    }

}
Console.WriteLine("Enter numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter numb of min elem: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter numb of max elem: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = New2dArray(m, n, min, max);

ShowArray(array);
FindSrednArifm(array);



