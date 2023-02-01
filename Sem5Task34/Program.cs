// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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
int ConvertArr(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}
//Тест элемента массива на четность
bool Test(int n)
{
    return (n%2==0);
}
//Записываем основной код
int[] testArr = Gen1DArray(10,100,999); // Генерируем массив по заданным в задачах параметрам
Print1DArr(testArr); // Выводим массив в консоль
int count = ConvertArr(testArr); // Подсчитываем кол-во четных элементов массива
PrintData("Количество четных элементов :"+count); //Выводим ответ в консоль 