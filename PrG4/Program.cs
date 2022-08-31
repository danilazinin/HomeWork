// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int i = 1;
while (i > 0 && i <= a)
{
    if ((i % 2) == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
}