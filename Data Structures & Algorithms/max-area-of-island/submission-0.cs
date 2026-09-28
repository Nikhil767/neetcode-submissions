public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int maxArea = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == 1)
                {
                    int area = DFS(grid, r, c);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }
        return maxArea;
    }

    private int DFS(int[][] grid, int r, int c)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        // Out of bounds or water → no area
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == 0)
            return 0;

        // Mark visited
        grid[r][c] = 0;

        // Count current cell + explore neighbors
        int area = 1;
        area += DFS(grid, r + 1, c);
        area += DFS(grid, r - 1, c);
        area += DFS(grid, r, c + 1);
        area += DFS(grid, r, c - 1);

        return area;
    }
}
