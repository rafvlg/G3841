// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру 
// разного цвета(цветов всего 16)

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] Gen2Darr(int xlen, int ylen)
{
    double[,] arr = new double[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return arr;
}

void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Console.Write(arr[i, j] + "\t");
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            //col[new System.Random().Next(0,16)]; 
            // Console.Write(InputNum[i, j] + " ");
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor(); 
            j++;
        }
        Console.WriteLine("");
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
double[,] matrix = Gen2Darr(xlen, ylen);
Print2DArr(matrix);


























