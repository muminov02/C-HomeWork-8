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

int[] FindArray(int[,] matr)
{
    int min = matr[0, 0];
    int[] arr = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                arr[0] = i;
                arr[1] = j;
            }
        }
    }
    Console.WriteLine(min);
    return arr;
}

int[,] NewArray(int[,] arr)
{
    int[] matr = FindArray(arr);
    int a = arr.GetLength(0) - 1;
    int b = arr.GetLength(1) - 1;
    int[,] newMatr = new int[a, b];
    int k = 0;

    for (int i = 0; i < a; i++)
    {
        int l = 0;
        for (int j = 0; j < b; j++)
        {
            if (k == matr[0]) { k++; newMatr[i, j] = arr[k, l]; }
            if (l == matr[1]) { l++; newMatr[i, j] = arr[k, l]; }
                newMatr[i, j] = arr[k, l];
                l++;
        }
        k++;
    }
    return newMatr;
}


int[,] matrix = new int[4, 4];
FillArray(matrix, -10, 10);
PrintArray(matrix);

Console.WriteLine();

PrintArray(NewArray(matrix));