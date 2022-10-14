// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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