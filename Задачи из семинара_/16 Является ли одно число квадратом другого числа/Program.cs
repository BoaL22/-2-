/*
    16. Напишите программу, которая принимает на
    вход два числа и проверяет, является ли одно
    число квадратом другого.
    5, 25 -> да
    -4, 16 -> да
    25, 5 -> да
    8,9 -> нет
*/

Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine());

if (A * A == B || B * B == A)
{
    Console.WriteLine("Да!");
}

else
{
    Console.WriteLine("Нет!");
}
