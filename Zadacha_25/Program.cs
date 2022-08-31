
Console.WriteLine("Введите число:");
bool isNumber = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("В какую степень возвести число?");
bool isDegree = int.TryParse(Console.ReadLine(), out int b);
if (!isNumber || !isDegree)
{
    Console.WriteLine("Вы не ввели число");
    return;
}

int GetDegree(int x, int y)
{
    int i = 0;
    int Degree = 1;
    for (i = 0; i < y; i++)
    {
        Degree = Degree* x;
    }
    return Degree;
}

Console.WriteLine(GetDegree(a, b));