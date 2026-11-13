public class Solution {
    public long MaxTotalValue(int[] nums, int k) {
        int min = nums[0];
        int max = nums[0];

        foreach(int i in nums){
            min = Math.Min(min , i);
            max = Math.Max(max , i);
        }

        return (long) (max - min) * k;
    }
}
