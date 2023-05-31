// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] CalculateColumnAverages(int[,] inArray)
{
    int numRows = inArray.GetLength(0);
    int numColumns = inArray.GetLength(1);
    double[] averages = new double[numColumns];
    for (int column = 0; column < numColumns; column++)
    {
        double columnSum = 0;
        for (int row = 0; row < numRows; row++)
        {
            columnSum += inArray[row, column];
        }
        averages[column] = columnSum / numRows;
    }

    return averages;
}

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
double[] columnAverages = CalculateColumnAverages(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
foreach (double average in columnAverages)
{
     Console.Write($"{average}; ");
}
