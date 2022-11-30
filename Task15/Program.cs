// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели ");
int numberA = int.Parse(Console.ReadLine());
if (numberA == 6 | numberA == 7)
{
    Console.WriteLine("Этот день ВЫХОДНОЙ");
}
else
{
    Console.WriteLine("Этот день НЕ выходной");
}
