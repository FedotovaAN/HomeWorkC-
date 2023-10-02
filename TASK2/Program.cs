// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("You first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You second number:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You third number:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > max)
{
    Console.WriteLine($"max = {b} ");
}
if(c > max)
{
    Console.WriteLine($"max = {c} ");
}







