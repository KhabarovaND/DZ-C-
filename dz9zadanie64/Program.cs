Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
NumberCounter(number);

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number == 0) return; //чтобы остановиться
    Console.Write("{0,4}", number);// 0,4 это отступы между числами чтобы было красиво
    NumberCounter (number - 1);//каждый раз отнимаем от числа 1 и, если оновсе еще не 0, выводим на экран
}


