


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}

//Функция Акермана
int Acerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Acerman(n - 1, 1);
    else
      return Acerman(n - 1, Acerman(n, m - 1));
}


//Вывод результата
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int sum = Acerman(m,n);
PrintResult("Значение функции Аккермана равно: ",sum);