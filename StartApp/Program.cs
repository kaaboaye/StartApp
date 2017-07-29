namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                System.Diagnostics.Process.Start(i);
            }
        }
    }
}
