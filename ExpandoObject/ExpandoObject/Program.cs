using System;
using System.Dynamic;

class Program
{
    static void Main()
    {
        dynamic dataStore = new ExpandoObject();
        dataStore.Alice = 1;
        dataStore.Betty = 2;
        Console.WriteLine(dataStore.Alice);
        Console.WriteLine(dataStore.Betty);
        Console.WriteLine(dataStore.Cindy);
    }
}
