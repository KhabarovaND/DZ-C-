Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
return AckermannFunction(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");