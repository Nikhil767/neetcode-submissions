public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0)
            return false;

        var count = new Dictionary<int, int>();
        foreach (int card in hand)
        {
            if (!count.ContainsKey(card))
                count[card] = 0;

            count[card]++;
        }

        Array.Sort(hand);

        foreach (int card in hand)
        {
            if (count[card] == 0)
                continue;

            // Try to form a group: card, card+1, ..., card+groupSize-1
            for (int i = 0; i < groupSize; i++)
            {
                int current = card + i;

                if (!count.ContainsKey(current) || count[current] == 0)
                    return false;

                count[current]--;
            }
        }

        return true;
    }
}
