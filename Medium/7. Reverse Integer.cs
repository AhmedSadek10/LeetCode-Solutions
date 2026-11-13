public class Solution {
    public int Reverse(int x) {
        int result = 0;

        while (x != 0){
            var remainder = x % 10;
            var temp = result * 10 + remainder;

            if ((temp - remainder) / 10 != result){
                return 0;
            }

            result = temp;
            x = x / 10;
        }
        return result;
    }
}
