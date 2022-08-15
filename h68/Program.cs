Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (n>0)
    {
        return Akkerman(m,n-1)*m; 
    }
    else
       if (n == 0) return 1;
}

Console.WriteLine(Akkerman(m,n));