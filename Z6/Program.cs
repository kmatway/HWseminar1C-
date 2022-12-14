// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число N = ");
int N = int.Parse(Console.ReadLine());

if(N%2 == 0)
{
    Console.WriteLine("Число N является четным");
}
else
{
    Console.WriteLine("Число N является нечетным");
}
