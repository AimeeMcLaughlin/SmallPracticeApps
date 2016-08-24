public string ReverseString(string s) {
        char[] charArray = s.ToCharArray();
            int a = s.Length;
            char[] tempArray = new char[s.Length];
            
            int b = a - 1;
        
            for(int i = 0; i < a; i++)
            {
                tempArray[i] = charArray[b];
                b--;
            }
        
            s = new string(tempArray);
            return s;

    }