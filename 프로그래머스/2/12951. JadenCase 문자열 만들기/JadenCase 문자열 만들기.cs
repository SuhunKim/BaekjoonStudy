using System;
using System.Collections.Generic;


public class Solution {
    public string solution(string s) {
        s=s.ToLower();
        
        string answer = "";
        
        string [] sArr = s.Split(' ');
        List<string> listStr = new List<string>();
        
        for(int i=0; i<sArr.Length; i++){
            if (string.IsNullOrEmpty(sArr[i])) {
                listStr.Add(sArr[i]); 
                continue;
            }
            string word = sArr[i];
            char[] cArr = word.ToCharArray();
            
            if(cArr[0]>=97 &&cArr[0]<=122){
                cArr[0]-=(char)32;
            }
            string sss = new string(cArr);
            
            answer+=sss+" "; 
            Console.WriteLine(sss);
            listStr.Add(sss);
        }
        
        
        Console.WriteLine(string.Join(" ",listStr));
        
        return string.Join(" ",listStr);
        //return answer.Trim();
    }
}