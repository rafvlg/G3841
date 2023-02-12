// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int row, int column, int range)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, range);
            j++;
        }
        i++;
    }
    return arr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//метод сортировки пузырьком
void Sort2DArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}


// 1. Получение данных от пользователя
int row = ReadData("Количество строк матрицы: ");
int column = ReadData("Количество столбцов матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до ..... ? : ");

// 2. Генерируем 2D массив
int[,] arr2D = Gen2DArray(row, column, range);

// 3. Печатаем 2D Массив
Console.WriteLine("Исходный 2D массив: ");
Print2DArray(arr2D);

// 4. Сортируем элементы массива по убыванию
Sort2DArray(arr2D);

// 5. Печатаем  отсортированны 2D Массив
Console.WriteLine();
Console.WriteLine("Отсортированный 2D массив: ");
Print2DArray(arr2D);