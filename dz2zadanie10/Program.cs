Console.WriteLine("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int a=0, b=0;
if (num>99)
{
    b = num;
    while (b>=100)
    {
        b/=10;
        a=b%10;
    }
    Console.WriteLine($"{a} - вторая цифра");
}
else
{
  Console.WriteLine("вторая цифра отсутствует");  
}