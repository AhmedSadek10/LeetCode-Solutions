class Solution {
    public int divisorSubstrings(int num, int k) {
        String s = String.valueOf(num);
        int res  = 0;
        for (int i = 0; i < s.length() - k + 1; i++){
            if(isGood(s.substring(i , i+k) , num))
                res ++;
        }
        return res;
    }
    public boolean isGood (String s , int num){
        if (Integer.valueOf(s) == 0) return false;
        return num % Integer.valueOf(s) == 0;
    }
}
