//Задача 58
int[,] CreateArray(int n, int m)
{
    return new int[n, m];
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] Checkmultiply(int[,] arr, int[,] arr2)
{
    int[,] result = new int[arr.GetLength(0), arr2.GetLength(1)];

    if (arr.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr.GetLength(0); i++)        
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    result[i, j] += arr[i, k] * arr2[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Можно перемножить матрицы, в одной из которых столбцов, столько же сколько строк во второй");   
    }
    return result;
}
int[,] arr = CreateArray(3, 2);
int[,] arr2 = CreateArray(2, 8);
FillArray(arr);
FillArray(arr2);
PrintArray(arr);
PrintArray(arr2);
int[,] result= Checkmultiply(arr, arr2);
PrintArray(result);



