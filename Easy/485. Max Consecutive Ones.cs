public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0;
        int current = 0;
        foreach(int i in nums){
            if (i == 1) {
                current++;
                result = Math.Max(current , result);
            }
            else{
                current = 0;
            }
        }
        return result;
    }
}
