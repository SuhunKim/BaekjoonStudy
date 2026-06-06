using System;

public class Solution {
    //public bool[] visited;
    public int[] arr ;
    //public int sum=0;
    public int count=0;
    public int statictarget=0;
    
    public int solution(int[] numbers, int target) {
        int answer = 0;
        
        arr = numbers;
        statictarget=target;
        
        int index=0;
        
        int sum=0;
        
     DFS(index,sum);
        
        
        answer=count;
        return answer;
    }
    
    public void DFS(int index, int sum){
        if(arr.Length-1==index){
            if(sum+arr[index]==statictarget){
                count++;
            }
            
            if(sum-arr[index]==statictarget){
                count++;
            }
            
            return ;
        }
        else{
            
            DFS(index+1,sum+arr[index]);
            DFS(index+1,sum-arr[index]);
        }
        
    }
    
   //public void DFS(int cur){
   //    if( visited[cur])   //이미 방문? return
   //        return;
   //    
   //    visited[cur]=true;  // 방문 체크
   //    
   //    for ( int i=0; i<arr.Length; i++){
   //        if(arr[cur,i]==1 && !visited[i]){
   //            DFS(i); //Next 진행
   //        }
   //    }
   //    
   //    
   //}
    
    
}