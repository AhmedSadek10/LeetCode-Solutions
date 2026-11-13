public class Solution {
    public string[] CreateGrid(int m, int n) {
        string [] grid = new string[m];

        grid [0] = new string('.' , n);

        for (int i = 1; i < m; i++){
            char [] row = new char[n];
            for(int j = 0; j < n; j++){
                row[j] = '#';
            }
            row[n - 1] = '.';

            grid[i] = new string(row);
        }
        return grid;
    }
}
