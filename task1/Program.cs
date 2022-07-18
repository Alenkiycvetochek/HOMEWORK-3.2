// / Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void PaliandromMeth (string n, string s)
{   
    char[] nReverse = n.ToCharArray();
    Array.Reverse(nReverse);
    s = new string(nReverse);
    
    if (n == s)
    Console.WriteLine (n + "This number is paliandrom");
    else
    Console.WriteLine (n + "This number is not poliandrom");
}

Console.WriteLine("Input five digit number:");
string num = Convert.ToString(Console.ReadLine());

PaliandromMeth(num, num);