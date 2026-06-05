using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[] {0,0 };
        // answer[0] == 이진변환 횟수
        // answer[1] == 제거된 0의 총 개수
        

        while ( !s.Equals("1")){
            

        int cnt = s.Count(x=>x=='0');   //c.Count(x=>x=="0");
        Console.WriteLine("Zero Count :");
        Console.WriteLine(cnt);
        answer[1]+=cnt; //제거한 0 추가

        string str = s.Replace("0","");
        Console.WriteLine("Delete Zero : ");
        Console.WriteLine(str); 
        
            int c = str.Length;
        s = Convert.ToString(c,2);
        Console.WriteLine("str>> Binary : ");
        Console.WriteLine(s); 
        
        
        answer[0] ++;
        
        }
        return answer;

    //int[] answer = new int[] {0,0 };
	//int cnt = 0;
	//int len = 0;
	//int convert = 0;
	//while (!s.Equals("1"))
    //      {
	//	//문자열에 0 세기     
	//	 answer[1]+= s.Length - s.Replace("0", "").Length;	//0의 개수를 cnt에 추가
	//	//문자열에서 0 제거
	//	s = Regex.Replace(s, "0", string.Empty);
	//	//s의 길이를 2진수로 바꿔 s에 대입
	//	len = s.Length;
	//	s = Convert.ToString(len, 2);
	//	convert++;
    //      }
    //answer[0] = convert;
	////answer[1] = cnt;
	//return answer;
    }
}