public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var indegree = new int [numCourses];
        var graph = new List<int>[numCourses];
        Array.Fill(indegree, 0);
        for(int i = 0; i < numCourses; i++){
            graph[i] = new List<int>();
        }
        
        foreach(var prerequisite in prerequisites){
            var course = prerequisite[0];
            var prerequisiteCourse = prerequisite[1];
            indegree[course]++;
            graph[prerequisiteCourse].Add(course);
        }

        var queue = new Queue<int>();

        for(int i = 0; i < numCourses; i++){
            if (indegree[i] == 0)
                queue.Enqueue(i);
        }
        var completedCourses = 0;
        while (queue.Count > 0){
            var course = queue.Dequeue();
            completedCourses++;

            foreach(var nextCourse in graph[course]){
                indegree[nextCourse]--;
                if (indegree[nextCourse] == 0){
                    queue.Enqueue(nextCourse);
                }
            }
        }
        return completedCourses == numCourses;
    }
}
