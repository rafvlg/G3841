//Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.
//Вариант 1

// char[]digit = Console.ReadLine().ToCharArray();

// if(digit.Length >= 3)
// {
// Console.WriteLine(digit[2]);

// }

// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

//Вариант 2

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()??"0");
//"Если значение более ста, то продолжаем, иначе выводим сообщение об ошибке"
if (number >= 100)
{
    //Уничтожаем хвостик после третьей цифры
    while (number > 999)
    {
        //Уничтожение последней цифры
        number = number / 10;
    }
    Console.WriteLine("третье число: ");
    //Выводим остаток от деления на 10( возвращаем последнюю цыфру)
    Console.WriteLine(number % 10);
}
else
{
    //Вывод ошибки
    Console.WriteLine("число не трёхзначное!");
}