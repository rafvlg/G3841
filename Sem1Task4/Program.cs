// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();

int A = int.Parse(inputNum1);
int B = int.Parse(inputNum2);
int C = int.Parse(inputNum3);

if (A > B)
{
    if(A > C)
    {
        Console.WriteLine("Из заданных чисел A больше");
    }
    else
    {
        Console.WriteLine("Из заданных чисел C больше");
    }
}
else
{
    if(B > C)
    {
            Console.WriteLine("Из заданных чисел B больше");
        }
        else
        {
            Console.WriteLine("Из заданных чисел C больше");
    }
}
