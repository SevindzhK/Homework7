// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);
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

void CheckNumber(int[,] array)
{
    Console.WriteLine("Enter the position of element you are looking for"); 
    Console.Write("Number of row: "); 
    int row = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Number of column: "); 
    int column = Convert.ToInt32(Console.ReadLine()); 

    if (row > rows || column > columns) 
    {
        Console.WriteLine("There is no such element");
    }
    else 
    {
        Console.WriteLine($"Element value is {array[row, column]}");
    }
}

CreateArray(array); 
CheckNumber(array); 
Console.WriteLine();
PrintArray(array); 