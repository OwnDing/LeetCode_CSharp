public int ThreeSumClosest(int[] nums, int target)
        {           
            int l = nums.Length;
            if (l < 3) return 0;           
            Array.Sort(nums);

            int result = 0;

            result = nums[0] + nums[1] + nums[2];

            for (int first = 0; first < l - 2; first++)
            {
                int second = first + 1;
                int third = nums.Length - 1;

                if (first > 0 && nums[first] == nums[first - 1])
                {
                    continue;
                }

                while (second < third)
                {
                    if (second > first + 1 && nums[second] == nums[second - 1])
                    {
                        second++;
                        continue;
                    }

                    int sum= nums[first] + nums[second] + nums[third];
                    if (Math.Abs(sum - target) < Math.Abs(result - target)) result = sum;
                    if (sum > target)
                    {
                        third--;
                    }
                    else
                    {
                        second++;
                    }
                }
            }

            return result;
        }
