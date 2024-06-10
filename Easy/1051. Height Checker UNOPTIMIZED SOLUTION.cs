// need optimization
public class Solution {
    public int HeightChecker(int[] heights) {
        int [] SortedHeights = new int [heights.Length];
        Array.Copy(heights,SortedHeights,heights.Length);
        Array.Sort(SortedHeights);
        int res = 0;
        for (int i = 0; i < heights.Length; i++){
            if (SortedHeights[i] != heights[i])
                res++;
        }
        return res;
    }
}
