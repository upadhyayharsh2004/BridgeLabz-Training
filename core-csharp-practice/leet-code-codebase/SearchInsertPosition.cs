using System;
namespace package{
    internal class SearchInsertPosition{
        public static void Main(string[]args) {
            int n=Convert.ToInt32(Console.ReadLine());
            int target=Convert.ToInt32(Console.ReadLine());
            int[]nums=new int[n];
            for(int i=0; i<nums.Length; i++){
                nums[i]=Convert.ToInt32(Console.ReadLine());
            }
            int start = 0;
            int end = nums.Length-1;
            bool found=false;
            while (start <= end) {
                int mid = start + (end-start)/2;
                if (nums[mid] == target){
                    Console.WriteLine(mid);
                    found=true;
                    break;
                }
                else if (nums[mid] > target){
                    end = mid-1;
                }
                else{
                    start = mid+1;
                }
            }
            if(!found){
                Console.WriteLine(-1);
            }
        }
    }
}