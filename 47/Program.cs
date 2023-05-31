// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    return result;
}


void PrintArray(double[,] arr)
{
    int accuracy = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0} ", Math.Round(arr[i, j], accuracy));
        }
        Console.WriteLine();
    }
}

double[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);





