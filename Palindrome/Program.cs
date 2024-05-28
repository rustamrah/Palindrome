internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine().ToLower();
            bool isPositive = true;
            List<string> asciiArray = new List<string>();
            for (int i = 0; i < 256; i++)
            {
                if (i >= 0 && i <= 47 || i >= 58 && i <= 64 ||  i >= 91 && i <= 96 || i >= 123 && i <= 191)
                {
                    char c = (char)i;
                    asciiArray.Add(Convert.ToString(c));
                }
            }

            for (int i = 0; i < asciiArray.Count; i++)
            {
                line = line.Replace(asciiArray[i], "");
            }
            string lineCopy = Reverse(line);

            if (line != "")
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != lineCopy[i])
                    {
                        isPositive = false;
                    }
                }
            }
            Console.WriteLine(isPositive);
        }
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
