public class Solution {
    public int GetMaximumGenerated(int n) {
        //new_approach
        //min runtime(17 ms);T(C(N)=O(n)) and S(C(n)=O(n)) due to by creating new additional (n+1)space with nth iteration and printing its max value 
       if(n==0)return 0;//initializing n 
       int[] nums=new int[n+1];// nums's size (n+1) declare 
       nums[1]=1;int max=1;//initially declare nums's 1st indx and n's val to 1 
       for(int i=2;i<=n;i++){//iterating from nums 2nd indx due to its current indx return
           nums[i]=nums[i/2]+i%2*nums[i/2+1];max=Math.Max(max,nums[i]);//updateing the nums current indx val to get maximum array's indx val
       }return max;}}

    //old_approach
     // int []nums=new int[n];int i =0;

        // //for(int i =0;i<nums.length();i++){
        //     for(i;i<n+1;i++){
        //     if(nums[0]==nums[i])nums[i]=0;
        //     else if (nums[i+1]>=nums[i])nums[i+1]=1;
        //     else if(nums[i*2]>=nums[i])nums[i]=nums[i*2]+nums[i];
        //     else if(nums[i+1]>=nums[i])nums[i]=nums[(i+1)*2]+nums[i+1];
        // }
        // Console.WriteLine(nums[i]);
