Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    if (n1 > n3)
    {
        Console.WriteLine("Максимальное число: " + n1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + n3);
    }
}

else if (n2 > n3)
{
    Console.WriteLine("Максимальное число: " + n2);
}
else
{
    Console.WriteLine("Максимальное число: " + n3);
}