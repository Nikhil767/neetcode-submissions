public class Solution {
    public int MinCostConnectPoints(int[][] points) {
      int n = points.Length;
    int[] minDist = new int[n];
    bool[] visited = new bool[n];

    Array.Fill(minDist, int.MaxValue);
    minDist[0] = 0;

    int result = 0;

    for (int i = 0; i < n; i++)
    {
        int u = -1;

        for (int j = 0; j < n; j++)
        {
            if (!visited[j] && (u == -1 || minDist[j] < minDist[u]))
            {
                u = j;
            }
        }

        visited[u] = true;
        result += minDist[u];

        for (int v = 0; v < n; v++)
        {
            if (!visited[v])
            {
                int dist = Math.Abs(points[u][0] - points[v][0]) +
                           Math.Abs(points[u][1] - points[v][1]);

                if (dist < minDist[v])
                {
                    minDist[v] = dist;
                }
            }
        }
    }

    return result;  
    }
}
