Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
int i = Math.Abs(x); // мудуль числа
int help1 = i / 1000;
int help2 = i / 10;
int a = i / 10000;
int a2 = i % 10;
int b = help1 % 10;
int b2 = help2 % 10;

if ((a/10) > 0)
{
    Console.WriteLine("не пятизначное число");
}
else if (a == a2 && b == b2)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
     Console.WriteLine("Число не является палиндромом");
}