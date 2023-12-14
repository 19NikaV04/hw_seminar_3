// Задача 1

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNambers(int M, int N)
{
    if(M > N) return;
    Console.Write(M + " ");
    PrintNambers(M + 1, N);
}

PrintNambers(M, N);
