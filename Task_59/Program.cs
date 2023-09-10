// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[] MinElementIndexes(int[,] matrix)
{
    int minElemRow = 0;
    int minElemColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minElemRow, minElemColumn])
            {
                minElemRow = i;
                minElemColumn = j;
            }
        }
    }
    return new int[] { minElemRow, minElemColumn };
}

int[,] NewMatrixDeleteMinElemIndexes(int[,] matrix, int delRow, int delCol)
{
    int m = 0, n = 0;
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        n = 0;
        if (m == delRow) m = m + 1; //m++; // пропуск строки
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == delCol) n = n + 1; //n++; // пропуск столбца
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return newMatrix;
}


int[,] array2d = CreateMatrixRndInt(4, 4, 1, 20);
PrintMatrix(array2d);
Console.WriteLine();
int[] minElementIndexes = MinElementIndexes(array2d);
int[,] newMatrixDeleteMinElemIndexes = NewMatrixDeleteMinElemIndexes(array2d, minElementIndexes[0], minElementIndexes[1]);
Console.WriteLine();
PrintMatrix(newMatrixDeleteMinElemIndexes);