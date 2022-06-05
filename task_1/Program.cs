void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to);
        }
    }
}

int[,] NewArray(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++) 
    { 
        for (int i = 0; i < arr.GetLength(1); i++) 
        { 
            for (int j = i + 1; j < arr.GetLength(1); j++) 
            { 
                if (arr[k, j] > arr[k, i]) 
                { 
                    (arr[k, i], arr[k, j]) = (arr[k, j], arr[k, i]); 
                } 
            } 
        } 
    } 
    return arr; 
}

int[,] matrix = new int[3, 4];
FillArray(matrix, 10, 25);
PrintArray(matrix);

Console.WriteLine();

PrintArray(NewArray(matrix));