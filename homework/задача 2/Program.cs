// задача 2 Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите целое число");
int y = Convert.ToInt32( Console.ReadLine());
if (x>y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}
