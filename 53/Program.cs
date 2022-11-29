// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void ChangeFirstLastRows(int[,] userArray)
{
    int temp = 0;
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        temp = userArray[0, i];
        userArray[0, i] = userArray[userArray.GetLength(1) - 1, i];
        userArray[userArray.GetLength(1) - 1, i] = temp;
    }
}

Console.Clear();
Console.Write("Введите колличество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = GetBinaryArray(row, col, 0, 10);
PrintBinaryArray(userArray);
ChangeFirstLastRows(userArray );
Console.WriteLine();
PrintBinaryArray(userArray);


