public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        int rows = grid.Length;
    int cols = grid[0].Length;

    Queue<(int r, int c)> queue = new Queue<(int r, int c)>();

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            if (grid[r][c] == 0)
            {
                queue.Enqueue((r, c));
            }
        }
    }

    int[][] directions = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };

    while (queue.Count > 0)
    {
        var (r, c) = queue.Dequeue();

        foreach (var dir in directions)
        {
            int nr = r + dir[0];
            int nc = c + dir[1];

            if (nr < 0 || nr >= rows || nc < 0 || nc >= cols ||
                grid[nr][nc] != int.MaxValue)
            {
                continue;
            }

            grid[nr][nc] = grid[r][c] + 1;
            queue.Enqueue((nr, nc));
        }
    }
    }
}
