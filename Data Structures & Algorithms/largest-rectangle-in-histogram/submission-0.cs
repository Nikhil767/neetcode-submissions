public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if (heights == null || heights.Length == 0)
        return 0;

    int maxArea = 0;
    Stack<int> stack = new();

    for (int i = 0; i <= heights.Length; i++)
    {
        int currentHeight = (i == heights.Length) ? 0 : heights[i];

        while (stack.Count > 0 && currentHeight < heights[stack.Peek()])
        {
            int height = heights[stack.Pop()];

            int right = i;
            int left = stack.Count == 0 ? -1 : stack.Peek();

            int width = right - left - 1;

            maxArea = Math.Max(maxArea, height * width);
        }

        stack.Push(i);
    }

    return maxArea;
    }
}
