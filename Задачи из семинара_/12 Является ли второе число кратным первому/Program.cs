/*
    12. Напишите программу, которая будет принимать на
    вход два числа и выводить, является ли второе число
    кратным первому. Если число 2 не кратно числу 1, то
    программа выводит остаток от деления.
    34, 5 -> не кратно, остаток 4
    16, 4 -> кратно
*/

Console.WriteLine("Введите перое число");
string numberA = Console.ReadLine();
int A = Convert.ToInt32(numberA);


Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine();
int B = Convert.ToInt32(numberB);


if (A % B == 0)
{
    Console.WriteLine("Кратно!");
}

else
{
    Console.WriteLine($"Не кратно, остаток = {A % B} ");
}