// задача 6 Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
if (x%2==0) Console.WriteLine("yes");
else Console.WriteLine("no");