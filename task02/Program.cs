Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(secondNumber > firstNumber)
{
    Console.WriteLine("Второе число больше первого: ");
}
else
{
    Console.WriteLine("Первое число больше второго: ");
}