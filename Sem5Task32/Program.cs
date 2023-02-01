// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] Gen1DArr(int num, int begin, int end)
// {
//     Random rnd = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(begin, end);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]+"]");
// }

// void InvArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]*=-1;
//     }
// }

// int[] InvArrNew(int[] arr)
// {
//     int[] newArr = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         newArr[i]=arr[i]*=-1;
//     }
//     return newArr;
// }

// int[] testArr = Gen1DArr(12, -9, 9);
// Print1DArr(testArr);
// InvArr(testArr);
// int[] testArrNew = InvArrNew(testArr);
// Print1DArr(testArr);

Random rnd = new Random();
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] create1DArray(int len, int num1, int num2)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
    }
    return arr;
}
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
int[] reverse1DArray(int[] array)
{
    int[] arr=array;
    for (int i = 0; i < array.Length; i++)
    {
        arr[i]*=-1;
    }
    return arr;
}
int len = InputNum("Введите длинну массива: ");
int num1 = InputNum("Введите минимум для значений в массиве: ");
int num2 = InputNum("Введите максимум для значений в массиве: ");
Console.WriteLine("Оригинал:");
int[]arr=create1DArray(len,num1,num2);
show1DArray(arr);
Console.WriteLine("реверс:");
int[]reverse_arr=reverse1DArray(arr);
show1DArray(arr);






