using System;

public class Solution {
    public int GetCol(int num, int w){
        int iRow = (num-1)/w;
        
        if(iRow%2==0){
            return (num-1)%w;
        }
        else{
            return (w-1)-((num-1)%w);
        }
    }
    
    //Main
    public int solution(int n, int w, int num) {
        int answer = 0;
        
        int iRow = (num-1)/w;
        int targetCol = GetCol(num, w);
        
        
        for (int i = num; i <= n; i++) {
            if (GetCol(i, w) == targetCol) {
                answer++;
            }
        }
        
            
            
            
        return answer;
    }
}