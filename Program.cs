/*
Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
 */




void PrintArry(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}


int[,] MultyArray(int[,] matrix, int[,] matrix1)
{
    int[,] matrixMulty = new int[matrix.GetLongLength(0), matrix.GetLongLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixMulty[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }
    return matrixMulty;
}



int[,] matrix = new int[3, 3];
int[,] matrix1 = new int[3, 3];

FillArray(matrix);
System.Console.WriteLine();
PrintArry(matrix);
FillArray(matrix1);
System.Console.WriteLine();
PrintArry(matrix1);
System.Console.WriteLine();
MultyArray(matrix, matrix1);
PrintArry(MultyArray(matrix, matrix1));

