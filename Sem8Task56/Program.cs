// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой 
//строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
// Метод считает сумму элементов строки массива
int SumLine(int[,] matr, int i)
{
    int sumLine = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sumLine += matr[i, j];
    }
    return sumLine;
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

//Находим строку с наименьшей суммой
int minSumLine = 0;
int sumLine = SumLine(arr2D, 0);
for (int i = 1; i < arr2D.GetLength(0); i++)
{
    int tempSumLine = SumLine(arr2D, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
minSumLine = minSumLine + 1;

// 5. Выводим результат на экран
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой равна: " + minSumLine);
Console.WriteLine("Наименьшая сумма равна: " + sumLine);





















