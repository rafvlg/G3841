// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
// Метод вычисляет произведение двух массивов (матриц)
void Mylti2DArray(int[,] matr1, int[,] matr2, int[,] resArr)
{

    for (int i = 0; i < resArr.GetLength(0); i++)
    {
        for (int j = 0; j < resArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, j];
            }
            resArr[i, j] = sum;
        }
    }
}


// 1. Получение данных от пользователя
int row1 = ReadData("Количество строк 1 матрицы: ");
int colFirstRowSec = ReadData("Количество строк 1 и столбцов 2 матрицы: ");
int column2 = ReadData("Количество столбцов 2 матрицы: ");
int range = ReadData("Диапазон элементов массива от 0 до ..... ? : ");
Console.WriteLine();

// 2. Генерируем первый 2D массив
int[,] arr2DOne = Gen2DArray(row1, colFirstRowSec, range);

// Генерируем второй 2D массив
int[,] arr2DTwo = Gen2DArray(colFirstRowSec, column2, range);

// 3. Печатаем оба массива
Console.WriteLine("Первый 2D массив: ");
Print2DArray(arr2DOne);
Console.WriteLine();
Console.WriteLine("Второй 2D массив: ");
Print2DArray(arr2DTwo);

// 4. Вычисляем произведение двух матриц
int[,] res2DArr = new int[row1, column2];
Mylti2DArray(arr2DOne, arr2DTwo, res2DArr);

// 6. Выводим результат
Console.WriteLine();
Console.WriteLine("произведение двух матриц: ");
Print2DArray(res2DArr);
