//Task1

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// int minRange = 10;
// int maxRange = 90;
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= minRange && array[i] <= maxRange)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);

// Task2

// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

// int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
// int cnt = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         cnt++;
//     }
// }
// Console.WriteLine(cnt);

//Task3

// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

// Начальные условия:

// int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double FindMin = array[0];
double FindMax = array[0];
double result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < FindMin)
    {
        FindMin = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > FindMax)
    {
        FindMax = array[i];
    }
}
Console.WriteLine(result = FindMax - FindMin);