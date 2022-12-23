// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумму натуральных элементов: {GetSum(num1, num2)}");

int GetSum(int num1, int num2)
{
    if (num1 == num2) 
    {
        return num1;
    }
    else if (num1 < num2) 
    {
        return num2 + GetSum(num1, num2 - 1);
    }
    else 
    return num2 + GetSum(num1, num2 + 1);
}