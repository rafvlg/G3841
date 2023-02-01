

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Summa(num1, num2);
// Console.WriteLine(Summa2(num1,num2) * 10);
// // Console.WriteLine("Сумма чисел");
// // int sum = num1 + num2;
// // Console.WriteLine(sum);

// void Summa(int num1, int num2)
// {
//     Console.WriteLine("Сумма чисел");
//     int sum = num1 + num2;
//     Console.WriteLine(sum);
// }

// int Summa2(int num1, int num2)
// {
//     Console.WriteLine("Сумма чисел");
//     int sum = num1 + num2;
//     return sum;
// }

// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

// string editLine(string text)
// {
//     string txt = text;
//     if (txt[txt.Length - 1] != ' ')
//     {
//         txt += " ";
//     }
//     return txt;
// }
// Random rnd = new Random();
// // метод генерации массива случайными числами
// int[] create1DArray(int len, int num1, int num2)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         // заполним массив минимальными и максимальными значениями
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// //  метод печати массива
// void show1DArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// // void show1DArrayWithMessage(string msg, int[] arr)
// // {
// //     Console.WriteLine(editLine(msg));
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         Console.Write(arr[i] + "\t");
// //     }
// //     Console.WriteLine(" ");
// // }
// //Ввод данных
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void revers(int[] arr)
// {
//     // int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//         (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
//         // temp=arr[i];
//         // arr[i]=arr[arr.Length-1-i];
//         // arr[arr.Length-1-i]=temp;
// }
// // Создание массива
// int[] arr = create1DArray(
//     InputNum("Введите длинну массива: "),
//     InputNum("Введите минимум для значений в массиве: "),
//     InputNum("Введите максимум для значений в массиве: ")
//     );
// // напечатаем
// show1DArray(arr);
// revers(arr);
// show1DArray(arr);


// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

// int a = ReadData("Введите первое число");
// int b = ReadData("Введите второе число");
// int c = ReadData("Введите третье число");

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// Console.WriteLine(b+c);
// if (a+c>b && a+b>c && b+c>a)
// {
//     Console.WriteLine("Треугольник Построить можно");
// }
// else
// {
//  Console.WriteLine("Треугольник построить нельзя");
// }


// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите целое число");
// int a = int.Parse(Console.ReadLine());
// string res ="";
// while(a > 0)
// {
//    res = Convert.ToString (a%2) + res; 
//    a = a / 2;
// }
// Console.WriteLine(res);


// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод Фибоначчи
int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

//Метод выводит на экран массив
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

int num = ReadData("Введите число: ");
Print1DArray(Fibonacci(num));




