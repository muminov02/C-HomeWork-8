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

void SumArray(int[,] arr1, int[,] arr2)
{
    int a1 = arr1.GetLength(0);
    int b1 = arr1.GetLength(1);
    int a2 = arr1.GetLength(0);
    int b2 = arr1.GetLength(1);
    if (a1 != a2 || b1 != b2) { Console.WriteLine("Arrays are not same size"); }
    else
    {
        int[,] newArr = new int[a1, b1];
    for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                newArr[i,j] = arr1[i,j] * arr2[i,j];
                Console.Write($"{newArr[i,j],3} ");
            }
            Console.WriteLine();
        }
    }
}

int[,] matrix = new int[3, 4];
int[,] matrix2 = new int[3, 4];
FillArray(matrix, 10, 25);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix2, 1, 15);
PrintArray(matrix2);

Console.WriteLine();

SumArray(matrix, matrix2);