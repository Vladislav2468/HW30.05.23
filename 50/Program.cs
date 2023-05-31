// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int GetElementValue(int[,] inArray, int rows, int columns)
{
    int numRows = inArray.GetLength(0);
    int numColumns = inArray.GetLength(1);

    if (rows >= 0 && rows < numRows && columns >= 0 && columns < numColumns)
        {
            return inArray[rows, columns];
        }
    return -1; 
}  


int Prompt(string message)
{
    Console.Write(message);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}


int[,] array = GetArray(4, 4, 1, 10);
PrintArray(array);
Console.WriteLine("====================");
int row = Prompt("Введите номер строки: ");
int column = Prompt("Введите номер столбца: ");
int value = GetElementValue(array, row - 1 , column - 1);
if (value != -1) 
{
     Console.WriteLine($"Значение элемента [{row},{column}]: {value}");
}
else
{
    Console.WriteLine($"Элемента [{row},{column}] не существует");
}