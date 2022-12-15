System.Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); // Читаем с клавиатуры размер массива и записываем в size
	
int[] array = new int[size]; // Создаём массив int размером в size
System.Console.WriteLine("Введите числа:");
/*пишем числа массив*/
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine()); ; // Заполняем массив элементами, введёнными с клавиатуры
}
int count = 0;
for (int i = 0; i < array.Length; i++) //проверяем каждое число на положительность)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");