#region FindMedianSortedArrays
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result;
            int l1=nums1.Length;
            int l2=nums2.Length;
            int numberlength = l1 + l2;
            
            List<int> listresult=new List<int>();

            if (l1 == 0)
            {
                listresult = nums2.OfType<int>().ToList();
            }
            else if (l2 == 0)
            {
                listresult = nums1.OfType<int>().ToList();
            }
            else if(l1<=l2){
                listresult=addnumbers(nums1,nums2,numberlength,l1,l2);
            }
            else{
                listresult=addnumbers(nums2,nums1,numberlength,l2,l1);
            }

            int num = numberlength / 2;
            int[] listtoarray = listresult.ToArray();
            if (numberlength % 2 != 0)
            {
                Console.WriteLine(listtoarray[num]);
                result = Convert.ToDouble(listtoarray[num]);
            }
            else
            {
                Console.WriteLine("{0};{1}", listtoarray[num - 1], listtoarray[num]);
                result = (listtoarray[num - 1] + listtoarray[num]) / 2.0f;
            }
            
            foreach(int item in listresult)
            {
                Console.WriteLine("Item:{0}",item);
            }

            return result;
        }

        private  List<int> addnumbers(int[] nums1,int[] nums2,int numberlength,int l1,int l2)
        {
            List<int> listresult=new List<int>();
            int i=0, j=0;
            bool b = true,b1=true;
            int num = numberlength;
            while(numberlength>0){
                if (nums1[i] <= nums2[j] && b)
                {
                    listresult.Add(nums1[i]);              
                    if (i < l1 - 1)
                    {
                      i++; 
                    }
                    else { b = false; }
                }
                else if(b1)
                {
                  listresult.Add(nums2[j]);
                  if (j < l2 - 1)
                    {
                      j++; 
                    }
                  else { b1 = false; }
                }
                else if (i + j <= num - 2)
                {
                    listresult.Add(nums1[i]);
                }
                numberlength--;
            }

            return listresult;
        }
        #endregion
