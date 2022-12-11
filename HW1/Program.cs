//Задача 1. 
/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1 + " " + "min = " + num2);
}

else
{
    Console.WriteLine("max = " + num2 + " " + "min = " + num1);
}
*/

//Задача 2.
/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("max = " + num1);
    }
    else
    {
        Console.WriteLine("max = " + num3);
    }
}

else if (num2 > num3)
{
    Console.WriteLine("max = " + num2);
}
else
{
    Console.WriteLine("max = " + num3);
}
*/

//Задача 3.
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 ==1)
{
    Console.WriteLine("number " + num + " является: нечетным");
}
else
{
    Console.WriteLine("number " + num + " является: четным");
}
*/

//Задача 4.
Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= N)
{
    if (N % 2 == 0)
    {
        Console.WriteLine(" " + current);
        current = current + 2;
    }
    else
    {
        Console.WriteLine(" " + current);
        current = current + 2;
    }
}