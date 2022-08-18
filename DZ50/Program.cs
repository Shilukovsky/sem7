Console.WriteLine("введите номер строки:");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца:");
int sto = Convert.ToInt32(Console.ReadLine());


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

void CheckPosition (int[,] matrix, int i, int j)
{
    if (i <= matrix.GetLength(0) && j <= matrix.GetLength(1))
        Console.WriteLine($"значение элемента с номером строки {str} и номером столбца {sto} -> {matrix[i-1,j-1]}");
    else
        Console.WriteLine("такого числа в массиве нет");
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

int[,] matrixResult = GetMatrix(3,4);
PrintMatrix(matrixResult);
Console.WriteLine();
CheckPosition(matrixResult, str, sto);

