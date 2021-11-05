// Создать на его основе масив B, отбрасывая те, которые
// 3  чётные

Console.Write("Array A: ");
int index = 0;
int[] array = new int[10];
while (index < 10)
{
    array[index] = new Random().Next(10, 100);
    index++;
}

index = 0;
while (index <= 9)
{
    int val = array[index];
    Console.Write($"{val} ");
    index++;
}
Console.WriteLine();

Console.Write("Array B: ");
index = 0;
while (index <= 9)
{
    if (array[index] % 2 != 0)
    {
        Console.Write($"{array[index]} ");
    }
    index++;
}