Console.WriteLine("Введите число");
try
{
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
Console.Write($"{i*i*i} " );
}
Console.WriteLine();
}
catch
{
    Console.WriteLine("некорректный ввод данных");
}