Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

 if (num1 >= num2)
 {
    if (num3 >= num1)
    {
       Console.WriteLine ("{0} наибольшее число", num3);
    }
    else
    {
       Console.WriteLine ( "{0} наибольшее число", num1);
    }
 }
 else
 {
    if (num3 >= num2)
    {
       Console.WriteLine ("{0} наибольшее число", num3);
    }
    else
    {
       Console.WriteLine ("{0} наибольшее число", num1);
    }
 }