// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)  // int[,] это означает двухмерный массив. int[,,] это означает трехмерный массив. Сюда мы положили наши 4 и 5, и мин./макс.значения
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++) // в этом цикле первая переменная равна нулю
    {
        for (int j = 0; j < n; j++) // и в этом цикле первая переменная равна нулю, т.е., мы начинаем с верхнего левого угла нашей таблицы.
        {
            result[i,j] = new Random(). Next(minValue,maxValue+1); // здесь массив будет рандомно заполняться, пока не достигнет кол-ва 4 строк и 5 столбцов
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
 for (int i = 0; i < inArray.GetLength(0); i++) // если строка, то в скобках 0
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // если столбец, то в скобках 1
        {
            Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine(); // чтобы был красивый вывод массива
    }    
}

// Метод

int[,] DescendingRowSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;    
            }
            int tmp = array[i, j];                                          
            array[i, j] = array[i, minPosition];                            
            array[i, minPosition] = tmp;                                    
        }

    }
    return array;
}

void PrintTable(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine();
int[,] sortRows = DescendingRowSort(array);
PrintTable(sortRows);