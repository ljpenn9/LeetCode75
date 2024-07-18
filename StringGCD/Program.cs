public class Program
{
    public static string GCDOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }
        else
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            while (len1 != 0 && len2 != 0)
            {
                if (len1 > len2) {
                    len1 %= len2;
                }
                else {
                    len2 %= len1;
                }
            }
            if (len1 != 0) {
                return str1.Substring(0, len1);
            }
            else {
                return str1.Substring(0, len2);
            }
        }
            
    }

    private static void Main(string[] args)
    {
        string firstWord = "ABABABABC";
        string secondWord = "ABAB";
        string gcd = GCDOfStrings(firstWord, secondWord);
        Console.WriteLine($"The first word is: {firstWord}");
        Console.WriteLine($"The second word is: {secondWord}");
        Console.WriteLine($"The GCD of both words is: |{gcd}|");
    }
}