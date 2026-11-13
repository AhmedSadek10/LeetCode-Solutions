public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        var adjacencyList = new List<List<int>>();
        for (int i = 0; i < n; i++){
            adjacencyList.Add(new List<int>());
        }
        foreach(var edge in edges){
            var firstNode = edge[0];
            var secondNode = edge[1];

            adjacencyList[firstNode].Add(secondNode);
            adjacencyList[secondNode].Add(firstNode);
        }
        var visited = new bool[n];
        var queue = new Queue<int>();
        queue.Enqueue(source);

        while(queue.Count > 0){
            int currentNode = queue.Dequeue();

            if (currentNode == destination)
                return true;

            foreach(var neighbor in adjacencyList[currentNode]){
                if (!visited[neighbor]){
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
        return false;
    }
}
