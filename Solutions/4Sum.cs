public IList<IList<int>> FourSum(int[] nums, int target)
        {
            if (nums.Length < 3) return new List<IList<int>>();
            Array.Sort(nums);
            return ThreeSum2(nums, new List<IList<int>>(),1,target);
        }

        public IList<IList<int>> ThreeSum2(int[] nums, IList<IList<int>> result,int start,int target)
        {
            int need_int = target - nums[start - 1];
            //Console.WriteLine("targe={0},start={1}",need_int,start);
            for (int first = start; first < nums.Length - 2; first++)
            {
                int second = first + 1;
                int third = nums.Length - 1;
                //Console.WriteLine("first={0},start={1}", first, start);
                if (nums[first] == nums[first - 1]  && first > start)
                {
                    continue;
                }

                while (second < third)
                {
                    //since first is constant in entire loop, if second is also same as previous iteration, then 3rd value will also be same. This will help optimization and removing duplicate results
                    if (second > first + 1 && nums[second] == nums[second - 1])
                    {
                        second++;
                        continue;
                    }

                    int sum = nums[first] + nums[second] + nums[third];
                    //Console.WriteLine("sum={0}", sum);
                    if (sum == need_int)
                    {
                        result.Add(new List<int> { nums[start-1],nums[first], nums[second], nums[third] });
                        second++;
                        third--;
                    }
                    else if (sum > need_int)
                    {
                        third--;
                    }
                    else
                    {
                        second++;
                    }
                }
            }

            if (start < nums.Length - 3)
            {
                while (nums[start] == nums[start - 1]) start++;
                ThreeSum2(nums, result, start + 1, target);
            }

            return result;
        }
