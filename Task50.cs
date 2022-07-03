// Задача 50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// ! Код написан в расчете на обыкновенного пользователя
// ! т.е. который нумерует строки и столбцы, начиная с 1

/*
Console.WriteLine();

int[,] array = new int[4,4];
Random rand = new Random();
int row;
int column;

FillArray(array);
PrintArray(array);
InputPosition(array);
PrintResult(array);

void FillArray(int[,] array)
{
for (row = 0; row < array.GetLength(0); row++)
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
void InputPosition(int[,] array)
{
Console.WriteLine("Введите номер строки:");
row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
column = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
void PrintResult(int[,] array)
{
if (row <= array.GetLength(0) && row > 0 && column <= array.GetLength(1) && column > 0)
{
    Console.WriteLine("Искомое значение: " + array[row-1,column-1]);
}
else
{
    Console.WriteLine("Такого значения в массиве нет");
}
}
*/