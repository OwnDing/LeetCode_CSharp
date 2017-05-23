public class Solution {
  #region int to roman
        public string IntToRoman(int num)
        {
            //if (num < 1 || num > 3999) return string.Empty;
            string[][] s = new string[4][];
            s[3] = new string[] { string.Empty, "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            s[2] = new string[] { string.Empty, "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            s[1] = new string[] { string.Empty, "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            s[0] = new string[] { string.Empty, "M", "MM", "MMM" };
            //string str = num.ToString();
            //int len = str.Length;
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < len; i++)
            //{
            //    result.Append(s[4-len+i][Convert.ToInt32(str[i].ToString())]);
            //}
            //return result.ToString();
            return s[0][num / 1000] + s[1][(num % 1000) / 100] + s[2][(num % 100) / 10] + s[3][num % 10];
        }
        #endregion
}
