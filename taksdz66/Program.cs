// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = vvod("Введите число начала промежутка: ");
int n = vvod("Введите число конца промежутка: ");

int vvod(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
if (m < 1) m = 1;
if (n < 1)
{
    Console.Write("В заданном диапозоне отсутствуют натуральные числа ");
}
else
{
    void SumRec (int m, int n) 
    {
        Console.Write("Сумма натуральных чисел в заданном диапозоне: = " + SumMN(m-1, n));
    }
    int SumMN(int m, int n)
    {    
        int result = m;
        if (m==n)
        return 0;
        else
        {
           m++;
           result = m + SumMN(m, n);
           return result;
        }        
    }
    SumRec(m, n);
}



