public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        Helper(result , "" , 0 , 0 ,n);
        return result;
    }

    public void Helper(List<string> result, string current, int open, int closed, int n){
        if (current.Length == n * 2){
            result.Add(current);
            return;
        }
        if (open < n){
            Helper(result , current + '(' , open + 1, closed , n);
        }
        if (open > closed){
            Helper(result , current  + ')', open , closed + 1 , n);
        }
    }
}

