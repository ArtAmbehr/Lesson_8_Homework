// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц (посмотреть в инете реализацию произведения 2 матриц).
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк массива для 1-й матрицы: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива для 1-й матрицы: ");
int columns1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива для 2-й матрицы: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива для 2-й матрицы: ");
int columns2 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random(). Next(minValue,maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
 for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine();
    }    
}

int[,] TwoMatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            product[i, j] = sum;

        }
    }
    return product;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] product = TwoMatrixProduct(array1, array2);
Console.WriteLine("---");
PrintMatrix(product);