public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var result = new List<string>();

        int targetIndex = 0;

        for (int streamValue = 1; streamValue <= n; streamValue++)
        {
            if (targetIndex == target.Length)
            {
                break;
            }

            result.Add("Push");

            if (target[targetIndex] == streamValue)
            {
                targetIndex++;
            }
            else
            {
                result.Add("Pop");
            }
        }

        return result;
    }
}
