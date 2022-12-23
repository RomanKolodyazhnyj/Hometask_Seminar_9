// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(PrintNumbers(num1, 1));
string PrintNumbers(int num1, int end)
{
    if (num1 == end)
    {
        return num1.ToString();
    }
    return (num1 + " " + PrintNumbers(num1 - 1, end));
}