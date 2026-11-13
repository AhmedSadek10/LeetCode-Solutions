public class Solution {

    private readonly List<IList<int>> res = new();

    public IList<IList<int>> Permute(int[] nums) {
        BackTrack(new List<int>(), nums);
        return res;
    }

    private void BackTrack(List<int> current, int [] nums)
    {
        if (current.Count() == nums.Length){
            res.Add(new List<int>(current));
            return;
        }
        else {
            foreach (int num in nums)
            {
                if (current.Contains(num))
                {
                    continue;
                }

                current.Add(num);
                BackTrack(current, nums);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
