public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int,int>();

        foreach (int stone in stones){
            pq.Enqueue(stone, -stone);
        }

        while(pq.Count > 1){
            int y = pq.Dequeue();
            int x = pq.Dequeue();

            if (x != y){
                pq.Enqueue(y - x, -(y - x));
            }
        }
        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}
