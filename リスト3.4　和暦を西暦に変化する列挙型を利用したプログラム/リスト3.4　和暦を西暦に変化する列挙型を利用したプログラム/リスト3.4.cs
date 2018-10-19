using System;

enum 年号
{
    明治, 大正, 昭和, 平成
}

class EnumSample
{
    // 和暦を西暦に変換する
    static void Main()
    {
        年号[] era = new 年号[5] { 年号.昭和, 年号.大正, 年号.明治, 年号.平成, 年号.昭和 };
        int[] j_year = new int[5] { 33, 12, 20, 10, 54 };
        int[] year = new int[5];

        Console.Write("和暦      西暦\n");
        for (int i = 0; i < 5; ++i)
        {
            switch (era[i])
            {
                case 年号.明治: year[i] = j_year[i] + 1863; break;
                case 年号.大正: year[i] = j_year[i] + 1911; break;
                case 年号.昭和: year[i] = j_year[i] + 1925; break;
                case 年号.平成: year[i] = j_year[i] + 1988; break;
            }

            Console.Write("{0}{1:d2}年 {2:d4}年\n", era[i], j_year[i], year[i]);
        }
    }
}
