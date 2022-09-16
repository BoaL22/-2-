/*
    11. Напишите программу, которая выводит случайное
    трёхзначное число и удаляет вторую цифру этого
    числа.
    456 -> 46
    782 -> 72
    918 -> 98
*/


int number = new Random().Next(100, 1000);
Console.WriteLine(number);

string numberA = Convert.ToString(number);

Console.WriteLine($"{numberA[0]}{numberA[2]}");
