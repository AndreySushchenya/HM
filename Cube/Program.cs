Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int start = 1;
Double cube = 0;

while (start < (i + 1))
{
    cube = Math.Pow(start,3);
    Console.WriteLine(cube);
    start++;
}