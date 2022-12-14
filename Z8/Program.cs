// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N = ");
int N = int.Parse(Console.ReadLine());

int a = 1;
while (a < N+1)
{
    if(a%2 == 0)
    {
        Console.WriteLine( + a );
        a = a + 1;
    }
    else
    {
        a = a + 1;
    }
}

