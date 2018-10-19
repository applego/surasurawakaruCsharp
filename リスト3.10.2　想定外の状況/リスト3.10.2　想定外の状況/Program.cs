using System;

class ExceptionSample
{
    // 文字→整数に変換する関数CharToInt
    static int CharToInt(char c)
    {
        return c - '0';
    }

    // 文字列→整数に変換する関数StringToInt
    static int StringToInt(string str)
    {
        int val = 0;
        foreach (char c in str)
        {
            int i = CharToInt(c);
            val = val * 10 + i;
        }
        return val;
    }

    static void Main()
    {
        Console.Write("{0}\n", StringToInt("12345"));
        Console.Write("{0}\n", StringToInt("12a45"));
    }
}
