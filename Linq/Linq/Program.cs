using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Program
{
    private static IEnumerable<int> src() => Enumerable.Range(0, 9);
    private static void output(int[] list)
    {
        foreach (var item in list) Console.Write(item);
        Console.WriteLine();
    }
    private static int[] oldStyle1(IEnumerable<int> src)
    {
        var list = new ArrayList();
        foreach (var item in src) list.Add(item * 2);
        return (int[])list.ToArray(typeof(int));
    }
    private static int[] oldStyle2(IEnumerable<int> src)
    {
        var list = new List<int>();
        foreach (var item in src) list.Add(item * 2);
        return list.ToArray();
    }
    private static int[] linqExpressionStyle(IEnumerable<int> src)
    {
        return (from n in src select n * 2).ToArray();
    }
    private static int[] linqMethodStyle(IEnumerable<int> src)
    {
        return src.Select(c => c * 2).ToArray();
    }
    static void Main()
    {
        output(oldStyle1(src()));
        output(oldStyle2(src()));
        output(linqExpressionStyle(src()));
        output(linqMethodStyle(src()));
    }
}
