// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Вводим данную команду, чтобы устранить ошибки отображения
using System.Numerics;
//Вводим метод
int Exponention(int numberA, int numberB)
{
    int result = 1;
    for(int i=1; i <= numberB; i++)
    {
        result = result* numberA;
    }
    return result;
}
//Вводим первое число 
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
//Вводим второе число
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

//Получаем ответ
int exponention = Exponention(numberA, numberB);
Console.WriteLine("Ответ: " +exponention);
