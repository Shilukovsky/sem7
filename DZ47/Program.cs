double[,] GetMatrix (int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.NextDouble()*10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1) - 1) Console.Write($"{Math.Round(array[i,j],1), 4},");
            else Console.Write($"{Math.Round(array[i,j],1), 4}]");
        }
        Console.WriteLine();
    }    
}

double[,] matrixResult = GetMatrix(3,4);
PrintMatrix(matrixResult);
