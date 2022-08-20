// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int length = number.Length;
int[] numbers = new int[length];
int sum = 0;
int count = 0;
while (count < length)
{
    numbers[count] = Convert.ToInt32(number[count].ToString());
    count++;
}
for (int i = 0; i < length; i++)
    sum += numbers[i];

Console.WriteLine(sum);