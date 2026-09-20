public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        // Build adjacency list
        var graph = new Dictionary<int, List<(int, int)>>();
        for (int i = 1; i <= n; i++)
            graph[i] = new List<(int, int)>();

        foreach (var t in times)
            graph[t[0]].Add((t[1], t[2]));

        // Min-heap for Dijkstra
        var pq = new PriorityQueue<(int node, int dist), int>();
        pq.Enqueue((k, 0), 0);

        var dist = new int[n + 1];
        Array.Fill(dist, int.MaxValue);
        dist[k] = 0;

        while (pq.Count > 0) {
            var (node, currDist) = pq.Dequeue();

            if (currDist > dist[node]) continue;

            foreach (var (next, time) in graph[node]) {
                int newDist = currDist + time;
                if (newDist < dist[next]) {
                    dist[next] = newDist;
                    pq.Enqueue((next, newDist), newDist);
                }
            }
        }

        int result = dist.Skip(1).Max();
        return result == int.MaxValue ? -1 : result;
    }
}
