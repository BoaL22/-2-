/*
    14. Напишите программу, которая принимает на
    вход число и проверяет, кратно ли оно
    одновременно 7 и 23.
    14 -> нет
    46 -> нет
    161 -> да
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int A = Convert.ToInt32(number);

if ( A % 23 == 0 && A % 7 == 0 )
{
    Console.WriteLine($" {A} кратно 7 и 23");
}


else
{
    Console.WriteLine($" {A} НЕ кратно 7 и 23");
}
