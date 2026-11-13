public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        var path = new List<int> { 0 };

        Dfs(0, graph, path, result);

        return result;
    }
    public void Dfs (int node, int [][] graph, List<int> path, List<IList<int>> result){
        if (node == graph.Length - 1)
        {
            result.Add(new List<int>(path));
            return;
        }

        foreach(var neighbour in graph[node]){
            path.Add(neighbour);

            Dfs(neighbour , graph , path , result);

            path.RemoveAt(path.Count - 1);
        }
    }
}
