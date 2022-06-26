/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine());
int numberMax = numberOne;


/* Изначально сделал вот такое вот уродство, но потом нашел лучшее решение)
if(numberMax < numberTwo)
{
     numberMax = numberTwo;
}
else {}

if(numberMax < numberThree)
{
     numberMax = numberThree;
}
else{} */

if(numberMax < numberTwo) numberMax = numberTwo;
if(numberMax < numberThree) numberMax = numberThree;

Console.WriteLine($" Максимальным числом является число {numberMax}");



