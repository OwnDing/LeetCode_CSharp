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
                if(i==s.Length||s[i]!=p[j]&&p[j]!='.'){
                    return false;
                }
                else
                {
                    return helper1(s, p, i+1, j + 1);
                }
            }

            //if p[j+1]=='*' && s[i] == p[j]
            while (i < s.Length && (s[i] == p[j]||p[j]=='.'))
            {
                if (helper1(s, p, i, j + 2))
                    return true;
                i++;
            }
            //if p[j+1]=='*' && s[i] != p[j]
            return helper1(s, p, i, j + 2);
        }
