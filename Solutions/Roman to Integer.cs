public class Solution {
    public int RomanToInt(string s) {
        int result=0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'M')
                {
                    result = result + 1000;
                }
                else if (s[i] == 'D')
                {
                    result = result + 500;
                }
                else if (s[i] == 'C' && i < s.Length-1 && (s[i+1] == 'D'||s[i+1] == 'M'))
                {
                    result = result -100;
                }
                else if (s[i] == 'C')
                {
                    result = result + 100;
                }
                else if (s[i] == 'L')
                {
                    result = result + 50;
                }
                else if (s[i] == 'X' && i < s.Length - 1 && (s[i + 1] == 'L'||s[i + 1] == 'C'))
                {
                    result = result - 10;
                }
                else if (s[i] == 'X')
                {
                    result = result + 10;
                }
                else if (s[i] == 'V')
                {
                    result = result + 5;
                }
                else if (s[i] == 'I' && i < s.Length - 1 && (s[i + 1] == 'V'||s[i + 1] == 'X'))
                {
                    result = result -1;
                }
                else
                {
                    result = result + 1;
                }
            }
                return result;
    }
}
