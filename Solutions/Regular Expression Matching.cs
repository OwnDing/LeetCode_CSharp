public class RegularExpressionMatching{
        public bool isMatch(String s, String p)
        {
            return MatchFunc(s, p, 0, 0);
        }
        private bool MatchFunc(string s, string p, int i, int j)
        {
            if (j >= p.Length) return i == s.Length;

            //if p[j+1]!='*'
            if (j == p.Length - 1 || p[j + 1] != '*')
            {
                if (i == s.Length || s[i] != p[j] && p[j] != '.')
                {
                    return false;
                }
                else
                {
                    return MatchFunc(s, p, i + 1, j + 1);
                }
            }

            //if (p[j+1]=='*' && s[i] == p[j])  
            //s[i]==s[i+1]==s[i+2]
            while (i < s.Length && (s[i] == p[j] || p[j] == '.'))
            {
                    return true;
            }
            //if p[j+1]=='*' && s[i] != p[j]
            return MatchFunc(s, p, i, j + 2);
        }

        private bool MatchFunc1(string s, string p)
        {
            int m = s.Length, n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];

            dp[0, 0] = true;
            for (int j = 1; j < n; j++) if (p[j] == '*') dp[0, j + 1] = dp[0, j - 1];
            //whatever p[0]!='*'
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (s[i] == p[j] || p[j] == '.') dp[i + 1, j + 1] = dp[i, j];
                    else if (p[j] == '*')
                    {
                    }
                }
            }

            return dp[m, n];
        }
}
