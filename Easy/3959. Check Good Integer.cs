public class Solution {
    public bool CheckGoodInteger(int n) {
        int digitSum = 0;
        int squareSum = 0;

        while (n > 0){
            int current = n % 10;
            n = (int)n / 10;

            digitSum += current;
            squareSum = squareSum + (current * current);
        }

        return squareSum - digitSum >= 50;
    }
}
