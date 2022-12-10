// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



 
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void FindElementValue(int[,] matrix, int fRow, int fColumn)
{ 
    if (fRow < 0 || fRow > matrix.GetLength(0) || fColumn < 0 || fColumn > matrix.GetLength(1)) 
    Console.WriteLine($"{fRow},{fColumn} -> такого элемента нет в массиве");   
    else Console.WriteLine(matrix[fRow, fColumn]);    
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
FindElementValue(array2D, 0, 0);
