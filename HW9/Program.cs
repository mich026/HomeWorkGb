// Задача 1.
/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
*/

void PrintNumbers(int num)
{   
     if (num > 0)
     {  
        Console.Write(num + " ");
        PrintNumbers(num - 1);
     }
     
 }

 Console.Write("Input a number: ");
 int n = Convert.ToInt32(Console.ReadLine());
 PrintNumbers(n);