// y = k1 * x + b1, y = k2 * x + b2
double pointX;
double pointY;
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//split в данном случае убирает пробел, 
//Int.Parse - это метод в C #, который преобразует строковое представление в соответствующее числовое 
//целочисленное значение.
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];
//здесь будут слезы тех, кто не учил геометрию в школе
if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"x= {pointX:0.00}");
    Console.WriteLine($"y= {pointY:0.00}");
}
