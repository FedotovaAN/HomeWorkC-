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

if(a > b)
if(a > c)
{
    Console.WriteLine($"max = {a} ");
}
else
{
   Console.WriteLine($"max = {c} "); 
}   
if(b > c)
if(b > a)
{
    Console.WriteLine($"max = {b} ");
}
else
{
   Console.WriteLine($"max = {a} "); 
}  
if(c > b)
if(c > a)
{
    Console.WriteLine($"max = {c} ");
}
else
{
   Console.WriteLine($"max = {a} "); 
}  