Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int start = 1;
int square = 0;

while (start < (i + 1))
{
    square = start * start;
    Console.WriteLine(square);
    start++;
}