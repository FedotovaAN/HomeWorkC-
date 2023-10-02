// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее;

Console.WriteLine("You first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You second number:");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"max = {a} ");
    Console.WriteLine($"min = {b} ");
}
else
{
   Console.WriteLine($"min = {a}");
   Console.WriteLine($"max = {b} ");
}

