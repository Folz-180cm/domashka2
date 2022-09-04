// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите 3-ёх значное число: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());
int final = 0;
if (threeDigit > 99 && threeDigit < 1000)
{
    threeDigit = threeDigit / 10;
    final = threeDigit % 10;
    Console.WriteLine($"Вторая цифра числа = {final}");
}
else
{
    Console.WriteLine($"Ошибка! Число {threeDigit} не 3-ёх значное! Введите другое число.");
}