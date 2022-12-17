// Задача2. Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int max = 0;

while (max != 0);
{
    if(a > b) max = a;
    if(a < b) max = b; 
}

Console.WriteLine($"max = {max}");