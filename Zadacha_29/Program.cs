// Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
# nullable disable

Console.WriteLine("Введите массив чисел через запятую");
string Arr = Console.ReadLine();

string RemoveComma(string str)
{
    string strNew = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ',')
        {
            strNew += str[i];
        }
    }
    return strNew;

}
string a = RemoveComma(Arr);
bool isNumber = int.TryParse(a, out int n);
if (!isNumber)
{
    Console.WriteLine("Какой-то из символов не является числом");
    return;
}

int[] GetArray(string tmp)
{
    int i = 0;
    int len = tmp.Length;
    int[] Arr = new int[tmp.Length];
    for (i = 0; i < len; i++)
    {
        Arr[i] = Convert.ToInt32(tmp[i].ToString());
    }
    return Arr;
}

void PrintArr(int[] b)
{
    int i = 0;
    int len = b.Length;
    Console.Write("[");
    for (i = 0; i < len-1; i++)
    {
        Console.Write($" {b[i]},");
    }
    Console.Write ($" {b[b.Length - 1]}");
    Console.Write("]");
}
GetArray(a);
PrintArr(GetArray(a));