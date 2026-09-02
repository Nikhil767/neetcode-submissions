public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int start = 0;
        int end = heights.Length-1;
        while(start < end)
        {
            var area = (end - start) * Math.Min(heights[start], heights[end]);
            if(maxArea<= area)
                maxArea = area;
            var shorter = Math.Min(heights[start], heights[end]);
            if(heights[start] > heights[end])            
                end--;            
            else            
                start++;            
        }
        return maxArea;
    }
}
