//Задача 56
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
int[] SumElementsInRow(int[,] array)
{
    int[] row = new int[array.GetLength(0)];
    int index = 0;
    int SumElements = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumElements = SumElements + array[i, j];
            
        }
       row[index] = SumElements;
       index++;
       SumElements =0;
       
    }
     return row;
}
void PrintOneStringArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }

}
int MinElementInArray(int [] array)
{   int Index =0;
    int Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(Min>array[i])
        {
            Min = array[i];
            Index = i;
        }
        
    }
    System.Console.WriteLine();
    System.Console.WriteLine(Index);
    return Index;
}
void PrintStringByIndex(int[,] array, int Index)
{
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[Index, j]}  ");
        }
        
    
    System.Console.WriteLine();
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
int[,] arr = CreateArray(8, 20);
FillArray(arr);
PrintArray(arr);
PrintArray(arr);
int[] OneStrArray = SumElementsInRow(arr);
PrintOneStringArray(OneStrArray);
int NumberOfString = MinElementInArray(OneStrArray);
PrintStringByIndex(arr, NumberOfString );
