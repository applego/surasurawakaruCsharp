using System;

class Program
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("正の数を入力してください: ");
            n = int.Parse(Console.ReadLine());
        }
        while (n < 1);

        Console.Write("あなたが入力した数値は{0}です", n);
    }
}