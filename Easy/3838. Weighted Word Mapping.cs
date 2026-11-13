public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        string res = "";

        foreach(string word in words){
            int stringSum = 0;
            foreach (char c in word){
                stringSum += weights[c - 'a'];
            }
            int mod = stringSum % 26;
            char mappedChar = (char)('z' - mod);

            res = res + mappedChar;
        }

        return res;
    }
}
