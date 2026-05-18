using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] signals) {
        int answer = -1;
        
        int n = signals.GetLength(0);
        int cur = 0;
        
        int index=0;
        
        List<int> listSumGYR = new List<int>();
        
        for(int i=0;i<n; i++){
            int sum=0;
            sum = signals[i,0]+signals[i,1]+signals[i,2];
            listSumGYR.Add(sum);
            }
         
        
        int TotalLCM=1;
        for(int i=0;i<listSumGYR.Count;i++){
           TotalLCM= LCM(TotalLCM,listSumGYR[i]);
        }
        
        //반복문이 TotalLCM가 되면 return -1;
        //Next -  GYR중 G=1~G / Y=g+1~ g+y / R = g+y~ g+y+r
        for(int t=1; t<=TotalLCM;t++){
            bool bYellow = true;
            
            for(int j=0;j<n; j++){
                int g=signals[j,0];
                int y=signals[j,1];
                int r=signals[j,2];
                    
                int iPos = (t-1)% listSumGYR[j]+1;
                
                if(!(g+1<=iPos && iPos<=g+y)){
                    bYellow=false;
                    break;
                }
            }
            if(bYellow)       
                return t;
                
        }
        return answer;
    }
        
    
    
    
    
    public int GCD(int a, int b){
          while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public int LCM(int a, int b){
        return (a*b)/GCD(a,b);
        //return (a+b)/GCD(a,b); 분자에 덧셈말고 곱셈
        
    }
}

        //signals[0] 2,1,2 =  Y=3(g+1)~ 3(g+y) / listSumGYR[0]+Y / listSumGYR[1]+Y ...
        //signals[1] 5.1.1 =  Y=6(g+1)~ 6(g+y) / listSumGYR[1]+Y / listSumGYR[1]+Y ...
        
        //1 : G G Y R R G G Y R R G G [Y] R R G G Y R R G G Y R R
        //2 : G G G G G Y R G G G G G [Y] R G G G G G Y R G G G G G Y R       
        
        //if a=b=c=Color.Yellow >> Blackout else return -1
        // GYR 각 1이상 18이하, 총합 3~20사이