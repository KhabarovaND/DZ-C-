Console.WriteLine("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int a=0, b=0;
if (num>99)
{
    b = num;
    while (b>=1000)
    {
        b/=10;
        a=b%10;
    }
    Console.WriteLine($"{a} - третья цифра");
}
else
{
  Console.WriteLine("третья цифра отсутствует");  
}