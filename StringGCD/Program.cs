public class Program
{
    public static string GCDOfStrings(string str1, string str2) {
        string gcd = "";
        return gcd;
    }

    private static void Main(string[] args)
    {
        string firstWord = "ABABAB";
        string secondWord = "ABAB";
        string gcd = GCDOfStrings(firstWord, secondWord);
        Console.WriteLine($"The first word is: {firstWord}");
        Console.WriteLine($"The second word is: {secondWord}");
        Console.WriteLine($"The GCD of both words is: |{gcd}|");
    }
}