import java.util.*;

class Solution {
    public int solution(int[] nums) {
        int answer = 0;
        int N = nums.length;
        int num = N/2;
        
        HashMap<Integer,Integer> hash =  new HashMap<>();
        for(int mon : nums){
            hash.put(mon,num);
        }
        
        if(num<hash.size()){
            answer=num;
        }
        else{
            answer=hash.size();
        }
        return answer;
    }
}