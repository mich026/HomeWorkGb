int CutNumber(int num)
{
    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNumb = new Random().Next(100, 1000);
int newNumb = CutNumber(randNumb);

Console.WriteLine($"New version of a number {randNumb} is {newNumb}");

тест