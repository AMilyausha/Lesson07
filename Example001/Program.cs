﻿// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными (тип double) числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void PrintArray(double [,] matrix)
{
    for (int i=0; i < matrix.GetLength(0); i++ )
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }   
};
Random rnd = new Random();
void FillArray ( double [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
            {
             matrix[i,j]=rnd.Next(-100,100);
            }
    }
}
double[,] matrix = new double [3,4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
