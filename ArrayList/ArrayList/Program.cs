using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(2);
        list.Add(3);
        int sum = (int)list[0] + (int)list[1];
        Console.WriteLine(sum);
    }
}
