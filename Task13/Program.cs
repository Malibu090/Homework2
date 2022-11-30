// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число ");
int numberA = int.Parse(Console.ReadLine());
if (99 < numberA & numberA < 1000)
{
    numberA = numberA % 10;
    Console.WriteLine($"третья цифра -> {numberA}");
}
else if (numberA < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (numberA > 999)
    {
        numberA = numberA / 10;
    }
    numberA = numberA % 10;
    Console.WriteLine($"третья цифра -> {numberA}");
}