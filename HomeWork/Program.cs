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