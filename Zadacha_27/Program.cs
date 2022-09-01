
Console.WriteLine("Введите число:");
bool isNumber = int.TryParse(Console.ReadLine(), out int a);
if (!isNumber)
{
    Console.WriteLine("Вы не ввели число");
    return;
}
int SumNumber(int numberN)
{
    int b = Convert.ToString(numberN).Length;
    int dif = 0;
    int sum = 0;

    for (int i = 0; i < b; i++)
    {
      dif = numberN - numberN % 10;
      sum = sum + (numberN - dif);
      numberN = numberN / 10;
      Console.WriteLine (sum);
    }
   return sum;
  }

Console.WriteLine (SumNumber(a));

