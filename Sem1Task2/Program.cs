// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();

int A = int.Parse(inputNum1);
int B = int.Parse(inputNum2);

if(A > B)
{
    Console.WriteLine("число A больше B");
}
else
{
    Console.WriteLine("число B больше A");
}



