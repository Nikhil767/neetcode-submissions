public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // HashSets for rows, columns, and boxes
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char val = board[r][c];

                if (val == '.') 
                    continue;

                // Row check
                if (rows[r].Contains(val))
                    return false;
                rows[r].Add(val);

                // Column check
                if (cols[c].Contains(val))
                    return false;
                cols[c].Add(val);

                // Box index: (r / 3) * 3 + (c / 3)
                int boxIndex = (r / 3) * 3 + (c / 3);
                if (boxes[boxIndex].Contains(val))
                    return false;
                boxes[boxIndex].Add(val);
            }
        }

        return true;
    }
}
