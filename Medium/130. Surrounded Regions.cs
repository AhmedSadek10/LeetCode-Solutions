public class Solution
{
    public void Solve(char[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        // 1. Mark border-connected O cells as safe
        for (int r = 0; r < rows; r++)
        {
            Dfs(board, r, 0);
            Dfs(board, r, cols - 1);
        }

        for (int c = 0; c < cols; c++)
        {
            Dfs(board, 0, c);
            Dfs(board, rows - 1, c);
        }

        // 2. Flip surrounded O to X, and safe S back to O
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (board[r][c] == 'O')
                {
                    board[r][c] = 'X';
                }
                else if (board[r][c] == 'S')
                {
                    board[r][c] = 'O';
                }
            }
        }
    }

    private void Dfs(char[][] board, int r, int c)
    {
        if (
            r < 0 ||
            c < 0 ||
            r >= board.Length ||
            c >= board[0].Length ||
            board[r][c] != 'O'
        )
        {
            return;
        }

        board[r][c] = 'S';

        Dfs(board, r + 1, c);
        Dfs(board, r - 1, c);
        Dfs(board, r, c + 1);
        Dfs(board, r, c - 1);
    }
}
