public class Solution {
    public int LargestAltitude(int[] gain) {
        int result = 0;
        int current = 0;
        foreach (int i in gain){
            current += i;
            result = Math.Max(current, result);
        }
        return result;
    }
}
