using System.Diagnostics;

internal class Program
{
    public static string MergeAlternately(string word1, string word2)
    {
        int shortWordLength = (word1.Length < word2.Length) ? word1.Length : word2.Length;
        string merged = "";

        for (int i = 0; i < shortWordLength; i++)
        {
            merged += word1[i];
            merged += word2[i];
        }

        if (word1.Length > shortWordLength)
            merged += word1.Substring(shortWordLength);
        else
            merged += word2.Substring(shortWordLength);

        return merged;
    }

    private static void Main(string[] args)
    {
        string firstWord = "abcd";
        string secondWord = "wxyz";
        string merged = MergeAlternately(firstWord, secondWord);
        Console.WriteLine($"The first word is: {firstWord}");
        Console.WriteLine($"The second word is: {secondWord}");
        Console.WriteLine($"The merged together word is: {merged}");
    }
}