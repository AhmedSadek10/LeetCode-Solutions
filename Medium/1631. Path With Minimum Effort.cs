public class Solution
{
    public int MinimumEffortPath(int[][] heights)
    {
        int rows = heights.Length;
        int cols = heights[0].Length;

        var efforts = new int[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                efforts[r, c] = int.MaxValue;
            }
        }

        efforts[0, 0] = 0;

        var pq = new PriorityQueue<(int row, int col), int>();
        pq.Enqueue((0, 0), 0);

        int[][] directions =
        {
            new[] { 1, 0 },
            new[] { -1, 0 },
            new[] { 0, 1 },
            new[] { 0, -1 }
        };

        while (pq.Count > 0)
        {
            pq.TryDequeue(out var current, out int currentEffort);

            int row = current.row;
            int col = current.col;

            if (row == rows - 1 && col == cols - 1)
                return currentEffort;

            if (currentEffort > efforts[row, col])
                continue;

            foreach (var dir in directions)
            {
                int newRow = row + dir[0];
                int newCol = col + dir[1];

                if (newRow < 0 || newRow >= rows ||
                    newCol < 0 || newCol >= cols)
                    continue;

                int edgeEffort = Math.Abs(
                    heights[row][col] - heights[newRow][newCol]
                );

                int newEffort = Math.Max(currentEffort, edgeEffort);

                if (newEffort < efforts[newRow, newCol])
                {
                    efforts[newRow, newCol] = newEffort;
                    pq.Enqueue((newRow, newCol), newEffort);
                }
            }
        }

        return 0;
    }
}
