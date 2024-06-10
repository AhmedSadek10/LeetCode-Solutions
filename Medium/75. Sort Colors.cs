public class Solution {
    public void SortColors(int[] nums) {
        int CountRed = 0;
        int CountWhite = 0;
        int CountBlue = 0;
        
        foreach (int i in nums){
            if (i == 0)
                CountRed = CountRed + 1;
            else if (i == 1)
                CountWhite = CountWhite + 1;
            else
                CountBlue = CountBlue + 1;
        }
        for (int i = 0; i < nums.Length; i++){
            if (CountRed > 0){
                nums[i] = 0;
                CountRed --;
            }
            else if (CountWhite > 0){
                nums[i] = 1;
                CountWhite --;
            }
            else{
                nums[i] = 2;
                CountBlue --;
            }
        }
    }
}
