public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        int res = 0;

        for (int i = s.Length - 1; i >=0; i--){
            if (s[i] != ' ')
                res++;
            else
                break;
        }
        return res;
    }
}
