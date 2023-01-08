Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

GapNumberSum(M, N, 0);

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

