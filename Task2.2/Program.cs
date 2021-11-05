// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// - элементы, больше 8

Console.Write("Array A: ");
int index = 0;
int[] array = new int[10];
int minValue = -10;
int maxValue = 20;
while (index < 10)
{
    array[index] = new Random().Next(minValue, maxValue);
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
    if (array[index] <= 8)
    {
        Console.Write($"{array[index]} ");
    }
    index++;
}