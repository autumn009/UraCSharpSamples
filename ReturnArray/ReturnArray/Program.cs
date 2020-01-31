using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static IEnumerable<int> makeCollectionNew(params int[] ar)
    {
        return ar.Select(c => c * 2);
    }
    private static int[] makeCollectionOld(params int[] ar)
    {
        var list = new ArrayList();
        foreach (var item in ar) list.Add(item * 2);
        return (int[])list.ToArray(typeof(int));
    }


    static void Main()
    {
        foreach (var item in makeCollectionNew(1, 2, 3)) Console.Write(item);
        Console.WriteLine();
        foreach (var item in makeCollectionOld(1, 2, 3)) Console.Write(item);
        Console.WriteLine();
    }
}
