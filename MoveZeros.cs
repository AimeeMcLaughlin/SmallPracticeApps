public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        int arrEnd = nums.Length - 1;
        
        for(int j = 0; j <=arrEnd - 1; j++)
        {
            for(i = 0; i <= arrEnd - 1; i++)
            {
                if(nums[i] == 0)
                {
                    if(nums[i + 1] > 0 || nums[i + 1] < 0)
                    {
                        int temp = nums[i];
                        nums[i] = nums[i+1];
                        nums[i+1] = temp;
                    }
                }
            }
        }
    }
}