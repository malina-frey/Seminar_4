/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(number > 0)
{
    number /= 10;
    count ++;
}
Console.WriteLine($"Количество чисел в вашем числе равняется {count}!");