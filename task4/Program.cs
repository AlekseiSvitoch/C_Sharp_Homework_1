// task4

Console.Clear();

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB && numberB == numberC)
    Console.WriteLine("числа равны");

else if (numberA > numberB && numberA > numberC)
    Console.WriteLine("max = " + numberA);

else if (numberB > numberC)
    Console.WriteLine("max = " + numberB);

else
    Console.WriteLine("max = " + numberC);
    