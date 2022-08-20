// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// int[] array = new int[8];
// var str = string.Join(" ", array);
// Console.WriteLine(str);

int[] Array = new int[8];
Random rnumber = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = rnumber.Next(1,99);
Console.Write($"{Array[i]} ");
}
Console.WriteLine();