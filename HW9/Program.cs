// Задача 1.

/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
*/
/*
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
 */

 // Задача 2.
 /*
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  
*/

     int SumNumbers(int m, int n)
     {
          if(m < n)
          { 
             return m + SumNumbers(m + 1,n);
          }
          if(m > n)
          {  
             return m + SumNumbers(m - 1,n);
          }

        return n;       
     }
    
     Console.Write("Enter number M: ");
     int m = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter number N: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int res = SumNumbers(m,n);
     Console.WriteLine("Sum: " + (res));

