int[,] CreateArray(int n, int m)
{
    return new int[n, m];
}
void FillArray(int[,] array)
{   
    int Number = 1;
    int size = array.GetLength(0);
    for (int i = 0; i < size / 2; i++)
    {
        for (int j = i; j < size - i; j++)
        {
            array[i, j] = Number;
            Number++;
        }

        for (int j = i + 1; j < size - i; j++)
        {
            array[j, size - i - 1] = Number;
            Number++;
        }

        for (int j = size - i - 2; j > i - 1; j--)
        {
            array[size - i - 1, j] = Number;
            Number++;
        }

        for (int j = size - i - 2; j > i; j--)
        {
            array[j, i] = Number;
            Number++;
        }
        
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] arr = CreateArray(4, 4);
FillArray(arr);
PrintArray(arr);