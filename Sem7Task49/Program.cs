// Задача №49
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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


void Update2Darr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        for (int j = 0; j < arr.GetLength(1); j=j+2)
        {
            arr[i, j]=(int)Math.Pow(arr[i, j],2);
        }
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2Darr(xlen, ylen);
Print2DArr(matrix);
Update2Darr(matrix);
Console.WriteLine();
Print2DArr(matrix);

























