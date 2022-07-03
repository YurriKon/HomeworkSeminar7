// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine();

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (column = 0; column < array.GetLength(1); column++)
    {
        array[row,column] = rand.Next(1, 100);
    }
}
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row,column] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

void Calculation(int[,] array)
{

}


