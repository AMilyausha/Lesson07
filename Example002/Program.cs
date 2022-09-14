// Задача 2. Напишите программу, которая на вход принимает позиции
// (две) элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = 0;
Random rnd = new Random();
// вывод массива на экран
void PrintArray(int [,] matrix)
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
 // Заполнение массива данными
void FillArray ( int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
            {
            matrix[i,j]=rnd.Next(1,100);
            if ( matrix[i,j]==num)
            {
                result = result + 1;
            }
             else 
            { 
                result=result;
            }  
            }
    }
}

void Result ()
{
    if ( result >0 ) 
    {
        Console.WriteLine($"{num} -> число {num} существует в этом массиве");
    }
    else 
    {
        Console.WriteLine($"{num} -> число {num} не существует в этом массиве");
    }
}

int[,] matrix = new int [3,4];

FillArray(matrix);
PrintArray(matrix);
Result();

