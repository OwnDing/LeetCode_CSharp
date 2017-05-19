public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            bool result = true;
            string str = x.ToString();
            int count=str.Length;

            if (count == 1) return true;

            int middle,left,right;
            if (count % 2 == 0)
            {
                left = count / 2 - 1;
                right = left + 1;
                
            }
            else
            {
                middle = count / 2;
                left = middle - 1;
                right = middle + 1;
            }

            while (left >= 0 && right <= count - 1)
            {
                //result = str[left] == str[right] ? true : false;
                if (str[left] != str[right])
                {
                    return false;
                }
                left--;
                right++;
            }
            return result;
        }
