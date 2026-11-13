public class Solution
{
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);

        int res = 0;
        int count = 0;

        for (int i = cost.Length - 1; i >= 0; i--)
        {
            count++;

            if (count == 3)
            {
                count = 0;
                continue;
            }

            res += cost[i];
        }

        return res;
    }
}
