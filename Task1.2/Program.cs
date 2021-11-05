// Создать на его основе масив B, отбрасывая те, которые
// 2  больше среднего арифметического элементов A

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

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i]; // sum = sum + array[i]
}
int A = sum / array.Length;
Console.WriteLine($"Arithmetic mean = {A}");

Console.Write("Array B: ");
index = 0;
while (index <= 9)
{
    if (array[index] <= A)
    {
        Console.Write($"{array[index]} ");
    }
    index++;
}