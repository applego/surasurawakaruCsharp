using System;

class Test
{
    public Test()
    {
        Console.Write("Test クラスのコンストラクターが呼ばれました\n");
    }

    ~Test()
    {
        Console.Write("Test クラスのデストラクターが呼ばれました\n");
    }
}

class DestructorSample
{
    static void Main()
    {
        Console.Write("1\n");
        Test t = new Test();
        Console.Write("2\n");
        t = null;
        Console.Write("3\n");
    }
}
