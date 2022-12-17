// Задача2. Напишите программу, которая на вход принимает три числа и выдает, 
// максимальное из этих чисел.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = 0;

while (max != 0);
{
    if(a > b & a > c) max = a;
    if(b > a & b > c) max = b;
    if(c > a & c > b) max = c;

}

Console.WriteLine($"max = {max}");