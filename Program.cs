namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastWordLength(GetInputs()));
        }

        public static string GetInputs()
        {
            string input;
            Console.Write($"Enter a string: ");
            input = Console.ReadLine() ?? "";
            return input;
        }

        public static int GetLastWordLength(string s)
        {
            string seperator = " ";
            string[] ws = s.Split(seperator);
            string lw = ws[ws.Length - 1];
            return lw.Length;
        }
    }
}
