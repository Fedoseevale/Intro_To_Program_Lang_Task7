// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - colomns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Задан массив:");

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);

Console.WriteLine("Введите номер строки интересующего элемента: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца интересующего элемента: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number1 < 0) | (number2 < 0))
{
    Console.WriteLine($"{number1}, {number2} -> введено недопустимое значение");
}

if ((number1 >= array2D.GetLength(0)) | (number2 >= array2D.GetLength(1)))
{
    Console.WriteLine($"{number1}, {number2} -> такого элемента в массиве нет");
}

if ((number1 < array2D.GetLength(0)) && (number2 < array2D.GetLength(1)))
{
    int number = array2D[number1, number2];
    Console.WriteLine($"{number1}, {number2} -> значение этого элемента равно {number}");
}





