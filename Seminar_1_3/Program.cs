Console.WriteLine("Введите число №1 ");
int N = Convert.ToInt32(Console.ReadLine());
int negative = N * (-1);
while (negative <= N)
{
    Console.Write(negative + " ");
    negative++;
}