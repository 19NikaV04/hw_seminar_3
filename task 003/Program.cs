// Задача 3

int[] numbers = {1,2,3,4,5,6,7,8,9};

void ConsoleWrite(int currentindex)
{
if (currentindex >= 1)
{
Console.WriteLine(numbers[currentindex - 1]);
ConsoleWrite(--currentindex);
}
}

ConsoleWrite(numbers.Length);
