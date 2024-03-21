namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static bool IsPalindrome(this string str)
        {
            str = str.Replace(" ", "").ToLower();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string name = "   Srikanth     ";
            string palindrome = "leveljkk";

            string interpolatedString = $"{greeting}, My name: {name}";
            char firstChar = greeting[0];
            int length = greeting.Length;
            bool isContains = greeting.Contains("He");
            string[] ar = interpolatedString.Split(' ');
            bool isPlaindrom = palindrome.IsPalindrome();
            Console.WriteLine(isPlaindrom);


            Console.WriteLine(name.Length);
            Console.WriteLine(name.Trim().Length);
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(interpolatedString);
            Console.WriteLine(firstChar);
            Console.WriteLine(length);
            Console.WriteLine(isContains);

        }
    }
}
