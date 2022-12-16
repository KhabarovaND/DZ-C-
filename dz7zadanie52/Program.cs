Console.WriteLine("Введите количество строк  ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lines, columns];//обявляем двумерный массив "numbers" с коллич.строк lines и с коллич.столбцов colums
FillArrayRandomNumbers(numbers);//используем объявленную функцию
PrintArray(numbers);
System.Console.WriteLine();
ArithmeticMean(numbers);



void FillArrayRandomNumbers(double[,] array)//объявляем функцию.заполняем массив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(1, 10));
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

void ArithmeticMean(double[,] array) //вычисляем ср.арифм.
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    
    string result = string.Format("{0:f1}", sum / array.GetLength(0));//пытаемся убрать дикое колличество цифр после запятой
    System.Console.WriteLine(result);
}
}
