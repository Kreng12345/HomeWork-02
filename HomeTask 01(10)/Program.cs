// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int number)
{
    int secDig = (number / 10) % 10;
    return secDig;
}

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.Write("Введенное число не трехзначное");
}

else
{
    int secDig = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} - {secDig}");
}