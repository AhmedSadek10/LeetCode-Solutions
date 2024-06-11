public class Solution {
    public int ClimbStairs(int n) {
        if (n == 0 || n == 1){
            return 1;
        }
        int [] fib = new int[n+1];
        fib[0] = fib[1] = 1;

        for (int i = 2; i <= n; i++){
            fib[i] = fib[i-1] + fib[i - 2];
        }
        return fib[n];
    }
}
//Space optimization
public class Solution {
    public int ClimbStairs(int n) {
        if (n == 0 || n == 1){
            return 1;
        }
        int prev = 1;
        int curr = 1;

        for (int i = 2; i <= n; i++){
            int temp = curr;
            curr = prev + curr;
            prev = temp;
        }
        return curr;
    }
}
