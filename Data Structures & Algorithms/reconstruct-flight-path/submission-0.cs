public class Solution {
    public List<string> FindItinerary(List<List<string>> tickets) {
        var graph = new Dictionary<string, PriorityQueue<string, string>>();

    foreach (var ticket in tickets)
    {
        string from = ticket[0];
        string to = ticket[1];

        if (!graph.ContainsKey(from))
            graph[from] = new PriorityQueue<string, string>();

        graph[from].Enqueue(to, to);
    }

    var route = new List<string>();

    void Dfs(string airport)
    {
        if (graph.ContainsKey(airport))
        {
            while (graph[airport].Count > 0)
            {
                string next = graph[airport].Dequeue();
                Dfs(next);
            }
        }

        route.Add(airport);
    }

    Dfs("JFK");
    route.Reverse();

    return route;
    }
}
