int[,] GetMatrix (int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

double GetSum (int[,] matrix)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            while (j < matrix.GetLength(0))
                sum += matrix[i,j] / matrix.GetLength(1);     
        }
    }   
    return sum; 
}

double[] GetArray (double sa, int n)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = sa;
    }
    return array;
}

void PrintMatrix(int[,] array)
{   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1) - 1) Console.Write($"{array[i,j], 3},");
            else Console.Write($"{array[i,j], 3}]");
        }
        Console.WriteLine();
    }    
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[,] matrixResult = GetMatrix(3,4);
PrintMatrix(matrixResult);
Console.WriteLine();
double summ = GetSum(matrixResult);
double[] array = GetArray(summ, 4);
PrintArray(array);
