using System;

class Test
{
    public Test()
    {
        Console.Write("コンストラクターが呼び出されました\n");
    }
}

class ConstructorSample
{
    static void Main()
    {
        Console.Write("Mainの先頭\n");

        Test t = new Test();

        Console.Write("Mainの末尾\n");
    }
}