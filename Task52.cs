// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine();

int[,] array = new int[4,5];
Random rand = new Random();

FillArray(array);
PrintArray(array);
Calculation(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Заданный массив:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void Calculation(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];

        }
        double aver;
        aver = (double)(sum/array.GetLength(0));
        Console.Write(Math.Round(aver, 2) + "\t");
    }
}
