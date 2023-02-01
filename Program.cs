// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Write("Введи число: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,1));

// ------------------Метод------------------
string PrintNumbers(int end, int start)
{
    if(end == start) return end.ToString();
    return (end + " " + PrintNumbers(end - 1, start));
}*/



//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*Console.WriteLine("Введите число  M"); 
int M = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Введите число  N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine(SumNumbers(M,N)); 
 
int SumNumbers(int M, int N) 
{ 
    if(M==0 || N==0) return 0;
    if(M == N) return M;
    return (M + SumNumbers(M + 1, N)); 
}*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/*Console.Write("Введите число  m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите число  n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Функция аккермана {FunctionAkkerman(m,n)}");

int FunctionAkkerman(int m, int n)
{
    if (m == 0) 
    return n + 1;

    else if ((m != 0) && (n == 0))
    return FunctionAkkerman(m - 1, 1);

    else
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}*/
