using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] jobs) {
        int answer = 0;
        
        int len = jobs.GetLength(0);     //jobs의 행 길이
        //1. 요청(번호, 요청시점, 소요시간) 큐
        List<int[]>  listRequest = new List<int[]>();
        for(int i=0; i<len;i++){
            listRequest.Add(new int []{ jobs[i, 0] ,jobs[i, 1] });
        }
        
        int now=0; //현재 시점 
        //2. listRequest에 저장되어있고 이게 비어있지않다면 우선순위 높은 애를 빼서 진행
        //우선순위 : 소요시간 짧은 순서 > 요청시점이 빠른 순서 > 작업 번호가 낮은 순서
        
       
        while(listRequest.Count>0){ //모든 리스트 소모될 때 까지 진행
            int iIndex=-1;  //  
            int minDuration =10000; //최소 소요시간 비교
            
            for(int i=0; i<listRequest.Count;i++)  //요청이있다면 모든 요청 스캔하며 어떤항목을 진행할 지 확인.
            {
                if(listRequest[i][0]<= now){    //요청 시점이 현재보다 빠른항목 찾기
                    if(listRequest[i][1]<minDuration){  //소요시간이 더 작은 항목인 지 확인
                        minDuration = listRequest[i][1];
                        iIndex=i;
                    }
                }
            }
            
            if(iIndex!=-1) {//할 작업이 있는 경우
                int[] current = listRequest[iIndex]; //지금 할 작업 불러오기 
                answer += (now - current[0])+current[1] ;//(현재-시점)= 대기시간.  + 소요시간current[1]
                now += current[1]; // now 갱신 
                
                listRequest.RemoveAt(iIndex); // 처리완료. 제거
            }
            else{//작업이 없는 경우 
             now++; //할거없음 1ms 증가    
            }            
        }
        
        return answer / len;
    }
}