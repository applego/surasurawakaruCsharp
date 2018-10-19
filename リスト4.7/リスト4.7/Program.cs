//プロパティ　見栄えの悪い例

using System;

// 「4.5　実装の隠蔽」で作った複素数クラス
class complex
{
    // 実装は外部から隠蔽（privateにしておく）
    private double re;  //　実部を記憶しておく
    private double im;　//　虚部を記憶しておく

    public double Re() { return this.re; }      //　実部を取り出す
    public void Re(double x) { this.re = x; }   //　実部を書き換え

    public double Im() { return this.im; }      //　虚部を取り出す
    public void In(double y) { this.im = y; }   //　虚部を書き換え

    //　絶対値を取り出す
    public double Abs() { return Math.Sqrt(re * re + im * im); }

}    
