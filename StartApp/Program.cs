using System;
using System.Diagnostics;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                try
                {
                    Process.Start(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{i}: {e.Message}");
                }
            }
        }
    }
}
