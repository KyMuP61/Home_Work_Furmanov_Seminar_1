/* Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введи число: ");
string number = Console.ReadLine();
int numberMax = int.Parse(number);
int numberMin = 1;

for (int i = numberMin; i <= numberMax; i++)
{
    if(i%2 == 0)
    {
        Console.WriteLine(i);
    }
    
}