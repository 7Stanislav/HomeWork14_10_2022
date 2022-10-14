// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("Введите число N:");
int n = int.Parse(Console.ReadLine());

string Recurs(int maxValue, int n)
{
    if(maxValue == n)
    {
        return n.ToString();
    }
    return (maxValue + " " + Recurs(maxValue - 1, n));
}
Console.WriteLine(Recurs(n, 1));
*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.Write("Введите число M:");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N:");
int n = int.Parse(Console.ReadLine());

int Recurs(int m, int n)
{
    if(m == n)
    {
        return n;
    }
    return (m + Recurs(m + 1, n));
}
Console.WriteLine(Recurs(m, n));
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M:");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N:");
int n = int.Parse(Console.ReadLine());

int functionAkkerman = Akkerman(m, n);

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.Write($"Результат {functionAkkerman} ");