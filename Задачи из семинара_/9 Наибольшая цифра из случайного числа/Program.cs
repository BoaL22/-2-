/*
    9. Напишите программу, которая выводит
    случайное число из отрезка [10, 99] и показывает
    наибольшую цифру числа.
    78 -> 8
    12-> 2
    85 -> 8
*/

int number = new Random() .Next (10, 100);
Convert.ToString(number);
Console.WriteLine(number);


string numberA = Convert.ToString(number);

if (numberA[1] > numberA[0])
{
    Console.WriteLine($"Наибольшая цифра из {number} -> {numberA[1]}");
}

else 
{
    Console.WriteLine($"Наибольшая цифра из {number} -> {numberA[0]}");
}
