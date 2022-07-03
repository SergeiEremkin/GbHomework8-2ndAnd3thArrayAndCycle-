//Задача 60
int[,,] CreateArray(int n, int m, int k)
{
    return new int[n, m, k];
}
void FillArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = CheckArrayForRepeatNumbers(array);

            }
        }
    }
}
int CheckArrayForRepeatNumbers(int[,,] array)
{
    bool CheckNumber = false;
    int RandomNumber = new Random().Next(10, 100);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == RandomNumber)
                {
                    CheckNumber = true;
                    break;
                }

            }
        }
    }
    if (CheckNumber == true)
    {
        return CheckArrayForRepeatNumbers(array);
    }
    else
    {
        return RandomNumber;
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                System.Console.Write($"{array[i, j, l]} ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] arr = CreateArray(2, 4, 6);
FillArray(arr);
PrintArray(arr);

