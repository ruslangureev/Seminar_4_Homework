Console.WriteLine("Vvedite chislo: ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a / 10;
}
Console.WriteLine("сумма чисел равна: " + sum);
