public class Solution {
    public int MaxProduct(int[] nums) {
        var minHeap = new PriorityQueue<int,int>();

        foreach (var n in nums){
            minHeap.Enqueue(n , -n);
        } 

        return (minHeap.Dequeue()-1) * (minHeap.Dequeue()-1);
    }
}
