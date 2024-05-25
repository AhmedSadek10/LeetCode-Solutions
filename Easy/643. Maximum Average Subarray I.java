class Solution {
    public double findMaxAverage(int[] nums, int k) {
        int currentSum = 0;
        int maxSum = 0;

        for (int i = 0; i < k; i++)
            maxSum += nums[i];

        currentSum = maxSum;
        for (int i = k; i < nums.length; i++){
            currentSum += nums[i] - nums[i-k];
            maxSum = Math.max(maxSum , currentSum);
        }
        return (double) maxSum / k;
    }
}
