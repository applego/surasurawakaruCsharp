using System;

//　クラス定義
class Complex
{
    private double re;  //　実部を記憶しておく
    private double im;  //　虚部を記憶しておく

    public double Re() { return this.re; } 　    //　実部を取り出す
    public void Re(double x) { this.re = x; }   //　実部を書き換え

    public double Im() { return this.im; }      //　虚部を取り出す
    public void Im(double y) { this.im = y; }   //　虚部を書き換え

    //　絶対値を取り出す
    public double Abs() { return Math.Sqrt(re * re + im * im); }
}

//　クラス利用側
class ConcealSample
{
    static void Main()
    {
        Complex c = new Complex();
        c.Re(4);
        c.Im(3);
        Console.Write("|c|={0}\n", c.Abs());
    }
}