﻿int AverageValue(int[] nums)
{
    double sum = 0;
    int count = 0;
   for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]%6==0) 
        {
        sum += nums[i];
            count++;
        }

    }
   if (count ==0) { return 0; }
    return (int)sum / count;
}