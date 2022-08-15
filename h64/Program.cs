Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void ShowNum(int n, int m)
{
    if (m != n)
    {
        ShowNum(n, m-1);
    }

    Console.Write(m + " ");
}
Console.Write($"M = {m}; N = {n}. -> ");
ShowNum(m,n);
Console.Write($"\n");

//M = 1; N = 5. -> ""1, 2, 3, 4, 5""