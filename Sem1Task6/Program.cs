// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без 
// остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

string? inputNum1 = Console.ReadLine();
int A = int.Parse(inputNum1);
if(A % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}