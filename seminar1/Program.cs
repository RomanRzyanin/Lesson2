// task1

// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// тип_данных[] имяМассива = ...

// int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
// int numberForSearch = 44;
// bool isFound = false; // Число не найдено, false
// // точка старта; условие; действие с переменной счетчик 
// for (int i = 0; i < array.Length; i++)
// {
//     // Число нашли 
//     if (numberForSearch == array[i])
//     {
//         isFound = true;
//         break; // Сломали цикл, когда нашли число
//     }
// }
// if (isFound) // isFound == true
// {
//     Console.WriteLine("Да");
// }
// else// isFound == false
// {
//     Console.WriteLine("Нет");
// }

int [] arr = {1, 8, 4, 19, 8};

foreach ( int e  in arr)
{
    if (e == 8)
    {
        Console.WriteLine ("Yes");
        break;
    }
}
// max = arr[0];
// foreach (int e  in arr)
// {
//     if (e > max)
//     {
//         max = e;
//     }
// }
// Console.WriteLine(max);

//task2

// int[] array = {-1, -2, -3, -4, -5, 0, 1, 2, 3, 4, 5};
// Console.WriteLine($"Massive: [{string.Join("; ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
// }
// Console.WriteLine($"Result: [{string.Join("; ", array)}]");

//task3

// int[] array = {11, 22, 33, 44, 2, 3, 4};
// int[] result = new int[array.Length / 2];

//  for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
//  {
//     result[i] = array[i] * array[j];
//  }
//  Console.WriteLine($"Result: [{string.Join("; ", result)}]");