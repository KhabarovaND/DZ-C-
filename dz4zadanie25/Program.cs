Console.WriteLine("введите число A");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
double b = Convert.ToInt32(Console.ReadLine());
double n = a;

for (double i = 1; i < b; i++)
{
n = n * a;
}
Console.WriteLine($"{a} в степени {b} равно: {n}");