//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] CreateArray(int m, int n, int start, int finish)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            array[i, j] = random.Next(start, finish + 1);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i != array.GetLength(0) - 1) || (j != array.GetLength(1) - 1))
                Console.Write($"{array[i, j]}; ");
            else
                Console.WriteLine($"{array[i, j]}]");
        }
        Console.WriteLine();
    }
}



Console.Write("Введите количество строк массива 1 m= ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива 1 n= ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк массива 2 m= ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива 2 n= ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапозона start = ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание диапазона finish= ");
int finish = Convert.ToInt32(Console.ReadLine());
if (finish < start)
{
    int temp = finish;
    finish = start;
    start = temp;
}


int[,] arr1 = CreateArray(m1, n1, start, finish);
PrintArray(arr1);
int[,] arr2 = CreateArray(m2, n2, start, finish);
PrintArray(arr2);
int[,] arr = new int[m1, n2];
if (arr1.GetLength(1) == arr2.GetLength(0))
{

    for (int i = 0; i < arr1.GetLength(0); i++)//i<m1
    {
        for (int j = 0; j < arr2.GetLength(1); j++)// j<n2      
        {
            for (int l = 0; l < arr1.GetLength(1); l++)
            {
                arr[i, j] += arr1[i, l] * arr2[l, j];
            }
        }
    }
    PrintArray(arr);
}
else
{
    Console.WriteLine($"нельзя перемножить заданные матрицы размером [{m1},{n1}] и [{m2},{n2}]");
}
