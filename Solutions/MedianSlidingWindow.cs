#region MedianSlidingWindow
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            List<int> sorted = new List<int>();
            List<double> store = new List<double>();
            int even=k/2;
            int odd=k/2-1;

            for (int i = 0; i < k; i++)
            {
                sorted.Add(nums[i]);
            }
            sorted.Sort();
            store.Add(k % 2 == 0 ? ((double)sorted[odd]+sorted[odd+1])/2 : (double)sorted[even]);

            if(nums.Count()>k){
                for (int i = k; i < nums.Count(); i++)
                {
                    sorted.Remove(nums[i-k]);
                    int index = sorted.BinarySearch(nums[i]);
                    if (index < 0)
                    {
                        sorted.Insert(~index, nums[i]);
                    }
                    else
                    {
                        sorted.Insert(index, nums[i]);
                    }
                    store.Add(k % 2 == 0 ? ((double)sorted[odd] + sorted[odd + 1]) / 2 : (double)sorted[even]);
                }
            }
            
            return store.ToArray();
        }
        #endregion
