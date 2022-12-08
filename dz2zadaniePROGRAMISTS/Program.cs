Console.WriteLine("Введите колличество программистов");
int n = Convert.ToInt32(Console.ReadLine());
    if (n % 100>=10 & n % 100 <=20 )
    {
        Console.WriteLine($"{n} программистОВ");
    }
    else if (n % 10 == 1)
    {
        Console.WriteLine($"{n} программист");
    }
    else if (n % 10 >= 2 & n % 10 <= 4)
    {
        Console.WriteLine($"{n} программистА");
    }
    else
    {
        Console.WriteLine($"{n} программистОВ");
    }
