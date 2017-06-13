#region Letter Combinations of a Phone Number
        public IList<string> LetterCombinations(string digits)
        {
            if(digits==string.Empty) return new string[]{};
            
            return loopArray(new string[] { string.Empty }, 0, digits.Length - 1, digits);
        }

        private string[] loopArray(string[] data, int cur, int end, string digits)
        {
            string[][] digitstring=new string[10][];
            digitstring[0] = new string[] { string.Empty };
            digitstring[1] = new string[] { string.Empty };
            digitstring[2] = new string[] { "a","b","c" };
            digitstring[3] = new string[] { "d", "e", "f" };
            digitstring[4] = new string[] { "g", "h", "i" };
            digitstring[5] = new string[] { "j", "k", "l" };
            digitstring[6] = new string[] { "m", "n", "o" };
            digitstring[7] = new string[] { "p", "q", "r","s" };
            digitstring[8] = new string[] { "t", "u", "v" };
            digitstring[9] = new string[] { "w", "x", "y","z" };

            if (digits.Length == 1) return digitstring[Convert.ToInt32(digits)];

            int total = data.Length * digitstring[Convert.ToInt32(digits[cur].ToString())].Length;
            string[] result=new string[total];
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < digitstring[Convert.ToInt32(digits[cur].ToString())].Length; j++)
                {
                    result[count] = data[i] + digitstring[Convert.ToInt32(digits[cur].ToString())][j];
                    count++;
                }
            }

            if (cur < end)
                return loopArray(result, cur + 1, end, digits);

            return result;
        }
        #endregion
