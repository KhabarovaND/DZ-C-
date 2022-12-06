Console.WriteLine("введите первое целое число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе целое число");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1>n2)
{
Console.WriteLine($"число {n1} больше числа {n2}");
}
else
{
Console.WriteLine($"число {n2} больше числа {n1}");
}