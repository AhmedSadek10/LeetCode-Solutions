public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        var pq = new PriorityQueue<int, int>();
        var adjacencyList = new List<List<(int, int)>>();
        var distances = new int[n+1];
        Array.Fill(distances, int.MaxValue);
        distances[k] = 0;
        for (int i = 0; i <= n; i++){
            adjacencyList.Add(new List<(int, int)>());
        }

        foreach(var time in times){
            int from = time[0];
            int to = time[1];
            int cost = time[2];

            adjacencyList[from].Add((to, cost));
        }

        pq.Enqueue(k, 0);

        while(pq.Count > 0){
            pq.TryDequeue(out var node, out var cost);

            if (distances[node] < cost){
                    continue;
                }

            foreach((var negihbor, var weight) in adjacencyList[node]){
                var newCost = weight + cost;
                if (distances[negihbor] > newCost){
                    distances[negihbor] = newCost;
                    pq.Enqueue(negihbor, newCost);
                }
            }
        }

        var res = 0;
        for(int i = 1; i <= n; i++){
            if (distances[i] == int.MaxValue){
                return -1;
            }
            res = Math.Max(res , distances[i]);
        }

        return res;
    }       
}
