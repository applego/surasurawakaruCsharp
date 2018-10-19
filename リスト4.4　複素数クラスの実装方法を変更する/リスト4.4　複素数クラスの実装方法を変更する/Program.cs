using System;

//　クラス定義
class Complex
{
    // 絶対値を記憶しておく(外部からの読出し、書き換えも可能)
    public double abs;

    //　偏角を記憶しておく(外部からの読出し、書き換えも可能)
    public double arg;

    //　実部・虚部を書き換え
    public void Set(double x, double y)
    {
        this.abs = Math.Sqrt(x * x + y * y);
        this.arg = Math.Atan2(y, x);
    }
}

//　クラス利用側
class ConcealSample
{
    static void Main()
    {
        Complex c = new Complex();
        c.Set(4, 3);
        Console.Write("|c| = {0}\n", c.abs);
    }
}