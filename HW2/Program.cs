 // Задача 1. 
 /*
 int number = ReadInt("Введите трехзначное число: ");
 int amount = number.ToString().Length;
 
 if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
*/

// Задача 2. 
/*
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
*/

// Задача 3. 

Console.WriteLine("Введите день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

bool CheckDay(int num)
{

    if (num == 6 || num == 7) 
    {
        Console.WriteLine("Ответ: Выходной день.");
        return true;
    }
    else if  (num < 1 || num > 7)
    {
        Console.WriteLine("Ошибка: В неделе всего 7 дней!");
        return false;
    }
    else
    {
        Console.WriteLine("Ответ: Будний день.");
        return false;
    }
}


bool day = CheckDay(dayOfWeek);
Console.WriteLine(day);
