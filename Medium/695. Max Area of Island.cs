public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int ROWS = grid.Length, COLS = grid[0].Length;
        int maxSize = 0;

        for (int r = 0; r < ROWS; r++){
            for (int c = 0; c < COLS; c++){
                if (grid[r][c] == 1){
                    maxSize = Math.Max(maxSize , Dfs(grid, r, c));
                }
            }
        }

        return maxSize;   
    }
    public int Dfs (int[][] grid, int r, int c){
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 0)
            return 0;

        grid[r][c] = 0;
        int res = 1;

        res += Dfs(grid, r + 1, c);
        res += Dfs(grid, r - 1, c);
        res += Dfs(grid, r, c + 1);
        res += Dfs(grid, r, c - 1);

        return res;
    }
}

