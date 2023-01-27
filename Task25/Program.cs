// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0) number1 = number1 * -1;
if (number2 < 1) Console.WriteLine("Некорректный ввод!");

else
{
    int exponentiation = Expon(number1, number2);
    Console.WriteLine($"Число A, возведенное в степень B = {exponentiation}");

    int Expon(int num1, int num2)
    {
        int exponentiation = number1;
        for (int i = 1; i < number2; i++)
        {
            exponentiation = exponentiation * number1;
        }
        return exponentiation;
    }
}