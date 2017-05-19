#region Reverse digits of an integer
        public int Reverse(int x)
        {
            int reslut;
            string input = x >= 0 ? x.ToString() : (0-x).ToString() + "-";
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            bool t = Int32.TryParse(sb.ToString(), out reslut);

            return t ? reslut : 0;         
        }

        public int Reverse1(int x)
        {
            bool isNeg = x < 0;
            x = isNeg ? 0 - x : x;

            long res = 0;
            while (x > 0)
            {
                int lowest = x % 10;
                res = res * 10 + lowest;
                x = x / 10;
            }
            if (res > int.MaxValue)
            {
                return 0;
            }
            return isNeg ? (int)(0 - res) : (int)res;
        }
        #endregion
