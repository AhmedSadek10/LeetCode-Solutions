public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> result = new List<IList<int>>();
        Backtrack(n, k, 1, new List<int>(), result);
        return result;
    }

    private void Backtrack(int n, int k, int start, IList<int> combination, IList<IList<int>> result) {
        if (combination.Count == k) {
            result.Add(new List<int>(combination));
            return;
        }
        for (int i = start; i <= n; i++) {
            combination.Add(i);
            Backtrack(n, k, i + 1, combination, result);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
