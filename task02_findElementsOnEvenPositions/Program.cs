// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[5];
var newRand = new Random();
int OddSum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = newRand.Next(1, 10);
    Console.Write(array[i] + " ");
}

for (int i = 1; i < array.Length; i=i+2)
{
    OddSum = OddSum + array[i];
}
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях, равна {OddSum}");