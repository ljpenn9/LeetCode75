internal class Program
{
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> ans = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
            bool mostCandies = true;
            for (int k = 0; k < candies.Length; k++)
            {
                if (k != i)
                {
                    if (candies[k] > (candies[i] + extraCandies))
                    {
                        mostCandies = false;
                    }
                }
            }
            ans.Add(mostCandies);
        }
        return ans;
    }

    private static void Main(string[] args)
    {
        int[] numCandies = [2,3,5,1,3];
        int extraCandies = 3;

        IList<bool> result = KidsWithCandies(numCandies, extraCandies);

        foreach (bool item in result) {
            Console.Write(item + ", ");
        }
    }
}