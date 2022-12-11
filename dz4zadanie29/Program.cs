//Console.WriteLine("Введите размер массива:");
//int[] nums = new int[8];
//Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите массив:");
//int[] numbers = {Convert.ToInt32(Console.ReadLine())};
//Console.WriteLine(numbers[3]); 

System.Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); // Читаем с клавиатуры размер массива и записываем в size
	
int[] array = new int[size]; // Создаём массив int размером в size
System.Console.WriteLine("Введите числа:");
/*пишем числа массива*/
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine()); ; // Заполняем массив элементами, введёнными с клавиатуры
}
	string s = String.Join(", ", array);

		Console.WriteLine(s);
	

