// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = vvod("Введите неотрицательное число m: ");
int n = vvod("Введите неотрицательное число n: ");

int vvod(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}
AkkermanFun(m, n);

void AkkermanFun(int m, int n)
{
    Console.Write($"Функция Аккермана = {AkkFun(m, n)}");
}
int AkkFun(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (m > 0 && n == 0)
    {
        return AkkFun(m - 1, 1);
    }
    else 
    {
        return AkkFun(m - 1, AkkFun(m, n - 1));
    }
}
