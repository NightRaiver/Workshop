// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания

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
index = 1;
int currentElement = array[0];
Console.Write($"{currentElement} ");
while (index <= 9)
{
    if (array[index] > currentElement)
    {
        Console.Write($"{array[index]} ");
        currentElement = array[index];
    }
    index++;
}