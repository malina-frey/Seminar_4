/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void PrintArray(int[] Array)
{
        Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
        if (i < Array.Length - 1)
        {
            Console.Write(",");
        }
        
    }
    Console.Write("]");
}
int[] Array = new int[8];
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(0, 2);
}
PrintArray(Array);