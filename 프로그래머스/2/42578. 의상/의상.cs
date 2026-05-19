using System;
using System.Collections.Generic;


public class Solution {
    public int solution(string[,] clothes) {
        
        int answer = 1;
        int count = clothes.GetLength(0);
        
        List<string> listType = new   List<string>();
        Dictionary<string,int> hashCategoryCount = new Dictionary<string,int>();
        
        //1. 값 저장
        for(int i=0; i<count; i++){
            string sItem =clothes[i,0]; 
            string sType= clothes[i,1];
            listType.Add(sType);    // Type 개수
            
            if(hashCategoryCount.ContainsKey(sType)){
                //hashCategoryCount[sType].Add(sItem);
                hashCategoryCount[sType]+=1;
//Console.WriteLine(string.Format("{0} add 1 : {1}",sType,hashCategoryCount[sType].ToString()));
            }
            else{
                
                hashCategoryCount[sType]= 1;    //sItem;
//Console.WriteLine(string.Format("{0} add 1 : {1}",sType,hashCategoryCount[sType].ToString()));

            }
        }
        
        //2. Hash에서 값 곱하기
        //Console.WriteLine(hashCategoryCount[listType[0]]);
        foreach(string item in hashCategoryCount.Keys){
            answer*= (hashCategoryCount[item]+1);
        }   
        
        
        
        
        //Console.WriteLine(answer);
        return answer-1;
    }
}