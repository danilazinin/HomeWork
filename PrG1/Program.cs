Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b) 
{
     max = a;
     min = b;
     Console.WriteLine($"макс = {max}, минимальное = {min}");
}
else 
{
     max = b;
     min = a;
     Console.WriteLine($"макс = {max}, минимальное = {min}");
}
if ( a == b )
{
     Console.WriteLine("первое число равно второму");
}
