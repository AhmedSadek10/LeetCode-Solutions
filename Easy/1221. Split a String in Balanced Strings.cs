public class Solution {
    public int BalancedStringSplit(string s) {
        int current = 0;
        int result = 0;
        foreach (char c in s){
            if (c == 'R'){
                current++;
            }
            else {
                current--;
            }
            if (current == 0){
                result++;
            }
        }
        return result;
    }
}
