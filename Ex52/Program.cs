// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = new Random().Next(3, 4);
int columns = new Random().Next(3, 4);
int[,] array = new int[rows, columns];

void CreateArray(int[,] array)
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    } 
}

void GetAverageOfColumn(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            sum += array[i,j];
        }
        average = sum / rows; 
        Console.Write($"{average} ");
    }
}

CreateArray(array); 
PrintArray(array);
Console.WriteLine();
GetAverageOfColumn(array);
