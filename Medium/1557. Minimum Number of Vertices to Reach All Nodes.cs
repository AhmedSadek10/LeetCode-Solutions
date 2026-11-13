public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        var indegree = new int[n];

        foreach(var edge in edges){
            int to = edge[1];
            indegree[to]++;
        }
        
        var result = new List<int>();

        for(int node = 0; node < n; node++){
            if (indegree[node] == 0){
                result.Add(node);
            }
        }

        return result;
    }
}
