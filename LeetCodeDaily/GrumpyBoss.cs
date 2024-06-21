namespace LeetCodeDaily;
/*
There is a bookstore owner that has a store open for n minutes. 
Every minute, some number of customers enter the store. 
You are given an integer array customers of length n where customers[i] 
is the number of the customer that enters the store at the start of the ith minute 
and all those customers leave after the end of that minute.

On some minutes, the bookstore owner is grumpy. You are given a binary array grumpy
where grumpy[i] is 1 if the bookstore owner is grumpy during the ith minute, and is 0 otherwise.

When the bookstore owner is grumpy, the customers of that minute are not satisfied,
otherwise, they are satisfied.
The bookstore owner knows a secret technique to keep themselves not grumpy for 
minutes consecutive minutes, but can only use it once.

Return the maximum number of customers that can be satisfied throughout the day.
*/
public class GrumpyBoss
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        // current sum = min_possible_customers + unsatisfied_customers_withing_window

        var min_possible_customers = 0;
        for (int i = 0; i < customers.Length; ++i)
        {
            min_possible_customers =  grumpy[i] == 0 ? customers[i] + min_possible_customers : min_possible_customers;
        }
        var left = 0; 
        var right = 1; 
        var rolling_sum = min_possible_customers;
        if (grumpy[0] == 1){
            // if the first customer is unsatisfied, add them since they haven't been counted yet
            rolling_sum = customers[0] + min_possible_customers; 
        }
        // build the window
        while(right < minutes)
        {
            //only add to the rolling sum if customer is unsatisfied (and therefore uncounted)
            if (grumpy[right] == 1)
            {
                rolling_sum += customers[right];
            }
            
            right++;
        }
        // record the current rolling sum, it is the max so far
        var max = rolling_sum;
        while (right < customers.Length)
        {
            // as we push the left boundary of the window forward, we want 
            // to subtract the left most customer if they were originally unsatisfied
            if(grumpy[left] == 1){
                rolling_sum -= customers[left]; 
            }
            // then we add the rightmost customer if the were originally unsatisfied
            if (grumpy[right] == 1){
                rolling_sum += customers[right]; 
            }
            // now we want the max between the max and the rolling sum
            max = Math.Max(rolling_sum, max);
            // now push the window forward
            left++;
            right++;
        }
        return max;
    }
}
