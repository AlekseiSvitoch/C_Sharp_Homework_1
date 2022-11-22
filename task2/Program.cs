// task2

Console.Clear();

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("max = ");
    Console.Write(numberA);
}

else
{
    Console.Write("max = ");
    Console.Write(numberB);
}