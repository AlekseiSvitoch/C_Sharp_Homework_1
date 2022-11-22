Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int div = number % 2;

if (div == 0)
    Console.Write("Введенное число является четным");

else
    Console.Write("Введенное число является нечетным");
