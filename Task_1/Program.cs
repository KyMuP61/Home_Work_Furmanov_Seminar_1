/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
string number = Console.ReadLine();
int numberTwo = int.Parse(number);

if(numberOne > numberTwo)
{
    Console.WriteLine($"Первое число: {numberOne} больше второго числа: {numberTwo}");
}
else
{
    Console.WriteLine($"Второе число: {numberTwo} больше первого числа: {numberOne}");
}