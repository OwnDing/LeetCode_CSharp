public class Solution {
  #region Container With Most Water
        public int MaxArea(int[] height)
        {
            int count = height.Length;
            if (count < 2) return 0;
            int result=0;
            int minheight;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    minheight = height[i] > height[j] ? height[j] : height[i];
                    result=(j-i)*minheight>result?(j-i)*minheight:result;
                }
            }
            return result;
        }
        public int MaxArea1(int[] height)
        {
            int len = height.Length, low = 0, high = len - 1;
            int maxArea = 0;
            while (low < high)
            {
                maxArea = Math.Max(maxArea, (high - low) * Math.Min(height[low], height[high]));
                if (height[low] < height[high])
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return maxArea; 
        }
        #endregion
}
