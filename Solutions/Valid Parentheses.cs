public bool IsValid(string s)
        {
            Stack<char> collection = new Stack<char>();
            foreach (char c in s.ToCharArray())
            {
                if (c == '(')
                    collection.Push(')');
                else if (c == '[')
                    collection.Push(']');
                else if (c == '{')
                    collection.Push('}');
                else if (collection.Count == 0 || collection.Pop() != c)
                    return false;
            }

            return collection.Count==0?true:false;
        }
