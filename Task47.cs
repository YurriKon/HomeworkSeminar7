// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
// округлёнными до одного знака.
Console.WriteLine();
double[,] array = new double[4,4];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Math.Round((rand.NextDouble()*100 - 50), 1);
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

