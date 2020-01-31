using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    private static object lockobj = new object();
    private static void subNew()
    {
        lock (lockobj)
        {
            foreach (var item in Enumerable.Range(0, 10)) Console.Write(item);
        }
    }

    private static void subOld()
    {
        lock (typeof(Program))
        {
            foreach (var item in Enumerable.Range(0, 10)) Console.Write(item);
        }
    }


    static void Main()
    {
        var t1 = Task.Run(subNew);
        var t2 = Task.Run(subNew);
        Task.WaitAll(t1, t2);
        var t3 = Task.Run(subOld);
        var t4 = Task.Run(subOld);
        Task.WaitAll(t3, t4);
    }
}
