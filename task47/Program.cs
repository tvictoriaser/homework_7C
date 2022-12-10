// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double arr = rnd.NextDouble()*(max - min) + min;
            matrix[i, j] = Math.Round(arr, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4, -10, 10);
PrintMatrix(array2D);
