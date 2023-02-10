Console.WriteLine("Введите число №1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("число " + number1 + " квадрат числа " + number2);
} else 
{
    Console.WriteLine("число " + number1 + "не является квадрат числа " + number2);
}
