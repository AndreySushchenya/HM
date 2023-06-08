
int[] points = new int[2];
Console.WriteLine("Введите числа");

for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());
}

if (points[0] > 0 && points[1] > 0)
{
    Console.WriteLine("Четверть 1");
}
else if (points[0] < 0 && points[1] > 0)
{
    Console.WriteLine("Четверть 2");
}
else if (points[0] < 0 && points[1] < 0)
{
    Console.WriteLine("Четверть 3");
}
else if (points[0] > 0 && points[1] < 0)
{
    Console.WriteLine("Четверть 4");
}
else
{
    Console.WriteLine("X или Y = 0");
}
