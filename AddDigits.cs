public class Solution {
    public int AddDigits(int num) {
        
        string myString = num.ToString();
        
        var charArray = myString.ToCharArray();
        
        int b = myString.Length;
        
        int a = 0;
        
        if(num > 10)
        {
                for(int i = 0; i < b; i++)
                {
                    char c = charArray[i];
                    a = a + int.Parse(c.ToString());
                }
                
                if(a > 10)
                {
                    a = AddDigits(a);
                }
                else if( a == 10)
                {
                    a = a/10;
                }
        }
        else if( num == 10)
        {
                    a = num/10;
        }
        else
        {
            a = num;
        }
        
        
        
        return a;
    }
}