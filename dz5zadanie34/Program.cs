Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size]; //создаем массив numbers размером size
FillArrayRandomNumbers(numbers); //вот эта штука нужна здесь для того, чтобы штука, которая заполняет массив рандомными числами работала
Console.WriteLine("массив: ");//это здесь для красоты
PrintArray(numbers);//вот эта штука нужна для того, чтобы штука которая выводит на экран те рандомные числа, которые мы запихнули в массив работала
////////////////////////////////////////////
int count = 0;
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)//тут мы проверяем, четное число или нет, если да, то запихиваем его в count
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
/////////////////////////////////////////////
void FillArrayRandomNumbers(int[] numbers) //заполняем массив numbers случайными 3х значными числами
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)//а вот эта штука выводит на экран тот самый рандомный набор
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}