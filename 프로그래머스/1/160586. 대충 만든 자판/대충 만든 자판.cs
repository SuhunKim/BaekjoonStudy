using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[] {};
        
        List<int> listResult = new  List<int>();
        //없는 문자가 있는 경우 몇몇 문자열은 작성할 수 없을 수도 있습니다.
        for(int i=0; i<targets.Length; i++){
            int count=0;
            int len = targets[i].Length;
            string str = targets[i];
                
            for(int j=0; j<len ; j++){
                //1. target[i]의 문자열 작성 시작
                char cTarget = str[j];
                int iTargetcnt = 0;
                int iIndex = 999;
                for(int k=0; k<keymap.Length; k++){
                    int idx = keymap[k].IndexOf(cTarget);
                    if(idx==-1){
                        continue;
                    }
                    if(iIndex>idx){
                        iIndex=idx+1;
                    }
                }
                
                if(iIndex==999){
                    count=0;
                    break;
                }
                count+=iIndex;
                Console.WriteLine(count);
            }   
                if(count==999||count==0){
                    listResult.Add(-1);
                }
                else{
                    listResult.Add(count);
                }
            
        }
        
        
        
        return listResult.ToArray();// answer;
    }
}