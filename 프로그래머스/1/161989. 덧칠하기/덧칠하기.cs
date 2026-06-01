using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        
        int len = section.Length;
        // 구역 : 1~n(각 1m)
        // 롤러 : m 미터
        int index=0;
        int i=0;
        
        while (i<=section[len-1]){
            if(i>section[index]){
                index++;
                continue;
            }
            if(i==section[index]){
                i+=m;
                answer++;
                index++;
                continue;

            }
            else{ 
                i++;
                continue;
}
            
        }
               
        
        return answer;
    }
}