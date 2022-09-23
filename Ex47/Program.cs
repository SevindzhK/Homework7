// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);
double[,] array = new double[rows, columns];

Random x = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToDouble(x.Next(-100, 100) / 10.0);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

