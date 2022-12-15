// Задача 1.
/*
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("в этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("] ");
    Console.WriteLine();
}*/

// Задача 2.
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int x = 0; x < numbers.Length; x+=2)
    sum = sum + numbers[x];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Задача 3.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}