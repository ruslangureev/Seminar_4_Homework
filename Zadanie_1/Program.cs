Console.WriteLine("Vvedite chislo a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite chislo b: ");
int b = int.Parse(Console.ReadLine());

int step = 1;
for (int i = 1; i <= b; ++i)
{
    step *= a;
}

Console.WriteLine(a + " в степени " + b + " равно: " + step);