Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number / number;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}