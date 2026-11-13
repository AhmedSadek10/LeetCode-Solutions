public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
        var adjacencyList = new List<List<(int, double)>>();

        for(int i = 0; i < n; i++){
            adjacencyList.Add(new List<(int , double)>());
        }

        var probs = new double[n];
        Array.Fill(probs, 0);
        probs[start_node] = 1;
        var pq = new PriorityQueue<int, double>();
        pq.Enqueue(start_node, -1);
        for(int i = 0; i < edges.Length; i++){
            int firstNode = edges[i][0];
            int secondNode = edges[i][1]; 
            double prob = succProb[i];

            adjacencyList[firstNode].Add((secondNode , prob));
            adjacencyList[secondNode].Add((firstNode , prob));
        }

        while (pq.Count > 0){
            pq.TryDequeue(out var node, out var priority);
            var prob = -priority;

            if (prob < probs[node]){
                continue;
            }

            if (node == end_node){
                return prob;
            }

            foreach((var neighbor, var weight) in adjacencyList[node]){
                var newProb = weight * prob;

                if (newProb > probs[neighbor]){
                    probs[neighbor] = newProb;
                    pq.Enqueue(neighbor, -newProb);
                }
            }
        }
        return 0.0;
    }
}
