using System;

class Program
{
    private static bool leotard(string blue, string red)
    {
        return blue == "root" && red == "password";
    }


    static void Main(string[] args)
    {
        if (leotard("root", "passwor"))
            Console.WriteLine("Logged in");
        else
            Console.WriteLine("Authentication failed");
    }
}
