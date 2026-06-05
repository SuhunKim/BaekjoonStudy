using System;
using System.Collections.Generic;
using System.Linq; 

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
        
        Array.Sort(A);
        
        Array.Sort(B);
        Array.Reverse(B); //B.OrderBy(n => n).ToArray();
        
        for(int i=0; i<A.Length; i++){
            answer+= (A[i]*B[i]);
            Console.WriteLine(i +"번째 곱 : "+A[i]*B[i] );
        }
        
        
        
        return answer;
    }
}