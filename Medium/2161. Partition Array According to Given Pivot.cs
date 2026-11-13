public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        var less = new List<int>();
        var equal = new List<int>();
        var greater = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < pivot)
            {
                less.Add(nums[i]);
            }
            else if (nums[i] == pivot)
            {
                equal.Add(nums[i]);
            }
            else
            {
                greater.Add(nums[i]);
            }
        }
        less.AddRange(equal);
        less.AddRange(greater);
        var result = new int[nums.Length];
        int index = 0;

        foreach(int i in less){
            result[index] = i;
            index++;
        }

        return result;
    }
}
