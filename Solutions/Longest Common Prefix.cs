public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            if (strs.Length == 0) return string.Empty;
            string maxprefix = strs[0];
            StringBuilder sb = new StringBuilder();
            int maxprefixnum = strs[0].Length;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < maxprefixnum)
                {
                    maxprefixnum = strs[i].Length;
                    maxprefix = strs[i];
                }
            }

            for (int i = 0; i < maxprefix.Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i]!=maxprefix[i])
                    {                       
                        return sb.ToString();
                    }                   
                }
                sb.Append(maxprefix[i]);
            }
            return sb.ToString();
    }
}
