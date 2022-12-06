Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 1) 
{
    Console.WriteLine($"Число {n} нечетное");
}
 else
{
    Console.WriteLine($"Число {n} четное");
}