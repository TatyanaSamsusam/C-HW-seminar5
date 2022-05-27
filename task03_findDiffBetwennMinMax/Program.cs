// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double[5];
var newRand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(newRand.NextDouble(),1);
    Console.Write(array[i] + " ");
}

double min = array[0]; double max = array[0];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
result = Math.Round(max - min,1);

Console.WriteLine();
Console.WriteLine($"минимальное число в массиве равно {min}, максимальное число равно {max}. разница между ними равна {result}");