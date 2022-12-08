Console.WriteLine("Введите число, обозначающее день недели");
int n = Convert.ToInt32(Console.ReadLine());
 if (n<6)
{
    Console.WriteLine("Рабочий день");
}
else 
{
Console.WriteLine("Выходной");
}