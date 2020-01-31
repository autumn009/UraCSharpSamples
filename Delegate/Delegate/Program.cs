using System;

class Program
{
    static void Main()
    {
        Action a = delegate ()
        {
            Console.WriteLine("In Anonymous Method");
        };
        Action b = () =>
        {
            Console.WriteLine("In Lambda Expression ");
        };
        a();
        b();
    }
}
