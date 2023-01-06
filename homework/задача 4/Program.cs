// задача 4 Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (x>y && x>z)
{
    Console.WriteLine(max=x);
}
else if (y>x && y>z)
{
    Console.WriteLine(max=y);
}
else if (z>x && z>y)
{
    Console.WriteLine(max=z);
}