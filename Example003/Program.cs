// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random rnd = new Random();
// вывод заполненного массива на экран
void PrintArray(int [,] matrix)
{
    for (int i=0; i < matrix.GetLength(0); i++ )
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rnd.Next(1,10);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }   
};

 // Нахождение среднего арифметического каждого столбца
void FillArray ( int [,] matrix)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {   
        double sum = 0;
        for (int i=0; i < matrix.GetLength(0); i++)
            {
             sum = sum + matrix[i,j];
            }
        double avg = Math.Round((sum / matrix.GetLength(0)),2);
        Console.Write($"{avg} ");   
    }
}

int[,] matrix = new int [3,4];
PrintArray(matrix);
Console.WriteLine("----------------");
FillArray(matrix);

