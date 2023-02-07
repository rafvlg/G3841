// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2Darr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}
// Печать двумерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}


void SerchElem(int[,] arr, int elem)
{
    bool elemFind = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elem == arr[i,j])
            {
                Console.WriteLine(elem + " найден " + i + j);
                // Console.WriteLine("найден");
                elemFind = true;
            }

        }
    }
    if (elemFind==false)
    {
        Console.WriteLine("Элемент не найден");
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int q = InputNum("Введите число: ");
int[,] matrix = Gen2Darr(xlen, ylen);

Print2DArr(matrix);
Console.WriteLine();
SerchElem(matrix,10);