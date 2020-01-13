using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float d = 0;
            float a = 0;
            foreach(var c in nums)
            {
                a += c;
            }
            d = a / nums.Length;
            return d;
        }
    }
}
