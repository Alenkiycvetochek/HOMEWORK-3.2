// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Kub (int a)
{
    for (int i = 1 ;i<=a; i++)
    {
        Console.Write(i * i * i + " ");
    }
}

Console.Write("Input number: ");
int kub = Convert.ToInt32(Console.ReadLine());

Kub (kub);