Console.WriteLine("Введите количество строк  ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double [lines, columns];//обявляем двумерный массив "numbers" с коллич.строк lines и с коллич.столбцов colums
FillArrayRandomNumbers(numbers);//используем объявленную функцию
PrintArray(numbers);
System.Console.WriteLine();
NumberRowMinSumElements(numbers);
System.Console.WriteLine();


void FillArrayRandomNumbers(double[,] array)//объявляем функцию.заполняем массив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void PrintArray(double[,] array)//выводим в терминал массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
// Функция вывода номера строки с наименьшей суммой элементов 
void NumberRowMinSumElements(double[,] array)
{
    double minRow = 0;
    double minSumRow = 0;
    double sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
         sumRow += array[i, j];//считаем сумму элемментов в строчки
        if (sumRow < minRow)//ЕСЛИ (сумма строчки МЕНЬШЕ минимальной)
        {                    
            minRow = sumRow; //ТО кладем это значение в minRow
            minSumRow = i;// и запоминаем ее номер
        }
        sumRow = 0;
    }
    Console.Write($"минимальная сумма элементов находится в {minSumRow + 1} строке");//+1 потому что для пользователя 0 строка это 1
}