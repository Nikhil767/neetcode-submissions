public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool first = false;
    bool second = false;
    bool third = false;

    foreach (var triplet in triplets)
    {
        // Skip invalid triplets
        if (triplet[0] > target[0] ||
            triplet[1] > target[1] ||
            triplet[2] > target[2])
        {
            continue;
        }

        if (triplet[0] == target[0])
            first = true;

        if (triplet[1] == target[1])
            second = true;

        if (triplet[2] == target[2])
            third = true;
    }

    return first && second && third;
    }
}
