public int MyAtoi(string str)
        {
            if (str == string.Empty) return 0;
            long result = 0;
            char m = '+';
            bool start = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!start)
                {
                    if (Spect(str[i].ToString()))
                    {
                        start = true;
                        if (str[i] == '-' || str[i] == '+')
                        {
                            m = str[i];
                        }
                        else
                        {
                            result = str[i] - '0';
                        }
                    }
                    else if (str[i] != ' ')
                    {
                        return 0;
                    }
                }
                else
                {
                    if (SpectNumber(str[i].ToString()))
                    {
                        result = result * 10 + (str[i] - '0');
                        if (m == '-')
                        {
                            if (0 - result < int.MinValue) return int.MinValue;
                        }
                        else
                        {
                            if (result > int.MaxValue) return int.MaxValue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return m == '-' ? (int)(0 - result) : (int)result; 
        }
        string[] num = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",  "-","+" };
        private bool Spect(string str)
        {
            bool b=false;
            for (int i = 0; i < num.Length; i++)
            {
                if(str==num[i])
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
        string[] number = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        private bool SpectNumber(string str)
        {
            bool b = false;
            for (int i = 0; i < number.Length; i++)
            {
                if (str == number[i])
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
