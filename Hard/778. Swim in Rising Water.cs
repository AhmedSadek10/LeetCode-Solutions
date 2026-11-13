public class Solution {
    public int SwimInWater(int[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var heights = new int [rows, cols];

        for(int r = 0; r < rows; r++){
            for (int c = 0; c < cols; c++){
                heights[r, c] = int.MaxValue;
            }
        } 

        heights[0, 0] = grid[0][0];

        int[][] directions =
        {
            new[] { 1, 0 },
            new[] { -1, 0 },
            new[] { 0, 1 },
            new[] { 0, -1 }
        };

        var pq = new PriorityQueue<(int row, int col) , int>();
        pq.Enqueue((0,0) , grid[0][0]);

        while (pq.Count > 0){
            pq.TryDequeue(out var current , out var currentHeight);
            var currentRow = current.row;
            var currentCol = current.col;

            if (currentRow == rows - 1 && currentCol == cols -1){
                return currentHeight;
            }
            if (currentHeight > heights[currentRow, currentCol]){
                continue;
            }
            foreach (var dir in directions){
                int newRow = currentRow + dir[0];
                int newCol = currentCol + dir[1];

                if (newRow < 0 || newRow >= rows ||
                    newCol < 0 || newCol >= cols)
                    continue;

                var newTime = Math.Max(currentHeight, grid[newRow][newCol]);

                if (newTime < heights[newRow, newCol]){
                    heights[newRow, newCol] = newTime;
                    pq.Enqueue((newRow, newCol) , newTime);
                }
            }
        }
        return heights[rows-1, cols-1];
    }
}
