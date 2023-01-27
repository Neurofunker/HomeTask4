// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;

int result = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");

int SumNumbers(int num)
{
    int sumNumbers = 0;
    while (num > 0)
    {
        sumNumbers = sumNumbers + num % 10;
        num = num / 10;
    }
    return sumNumbers;
}