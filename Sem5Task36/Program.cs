// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Метод вывода данных в консоль
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Метод генерации 1Д массива
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// Метод печати 1Д массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод подсчета элементов 1D массива по заданному условию
int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i = i+2)
    {
       res+=arr[i];
    }
    return res;
}

//Записываем основной код
int[] testArr = Gen1DArray(10,1,10); // Генерируем массив по заданным в задачах параметрам
Print1DArr(testArr); // Выводим массив в консоль
int oddValueSum = SumPos(testArr); // Подсчитываем кол-во элементов на нечетных позициях
PrintData("Сумма нечетных элементов массива :"+oddValueSum); //Выводим ответ в консоль 