using System;
using System.Collections;
using System.Linq;

public class IntCollectionWrapper
{
    private ArrayList list = new ArrayList();
    public void Add(int n)
    {
        list.Add(n);
    }
    public int[] GetArray()
    {
        return (int[])list.ToArray(typeof(int));
    }
}

class Program
{
    static void Main()
    {
        var x = new IntCollectionWrapper();
        x.Add(1);
        x.Add(2);
        Console.WriteLine(x.GetArray().Sum());
    }
}
