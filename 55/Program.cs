// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] GetBinaryArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintBinaryArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
        
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowsToCollums(int[,] userArray)
{
    
    if (userArray.GetLength(0) == userArray.GetLength(1))
    {
        int[,] resultArray = new int [userArray.GetLength(0), userArray.GetLength(1)];
        for (int i =0; i < userArray.GetLength(0); i++)
        {
            for (int j =0; j < userArray.GetLength(1); j++)
            {
               resultArray[i, j] = userArray[j, i];
            }
        }
    return resultArray;
    }
    else
    {
        Console.WriteLine("Невозможно преобразовать массив, массив останется таким же ");
        return userArray;
    }
}


Console.Clear();
Console.Write("Введите колличество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 0, 10);
PrintBinaryArray(userArray);
int[,] result = ChangeRowsToCollums(userArray);
Console.WriteLine();
PrintBinaryArray(result);

