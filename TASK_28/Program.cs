/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Div = 1;
var Sum = 1;
for (int i = 1; i <= number; i++)
{
    Sum = Sum * i;
}
Console.WriteLine($"Факториал вашего числа {number} равен {Sum}");