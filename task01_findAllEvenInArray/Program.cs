// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];
var newRand = new Random();
int EvenQty = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = newRand.Next(100, 1000);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    EvenQty = EvenQty + 1;
}
Console.WriteLine();
Console.WriteLine($"в этом массиве {EvenQty} четных чисел(-ла)");