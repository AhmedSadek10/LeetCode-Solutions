public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var result = new List<int>();
        var graph = new List<int>[numCourses];
        var indegree = new int[numCourses];
        Array.Fill(indegree, 0);
        var queue = new Queue<int>();

        for (int i = 0; i < numCourses; i++){
            graph[i] = new List<int>();
        }

        foreach(var prerequisite in prerequisites){
            var course = prerequisite[0];
            var prerequisiteCourse = prerequisite[1];

            indegree[course]++;
            graph[prerequisiteCourse].Add(course);
        }

        for (int i = 0; i < numCourses; i++){
            if(indegree[i] == 0)
                queue.Enqueue(i);
        }

        while(queue.Count > 0){
            var currentCourse = queue.Dequeue();
            result.Add(currentCourse);

            foreach(var nextCourse in graph[currentCourse]){
                indegree[nextCourse]--;
                if (indegree[nextCourse] == 0){
                    queue.Enqueue(nextCourse);
                }
            }
        }

        if (result.Count != numCourses){
            return new int[0];
        }

        return result.ToArray();
    }
}
