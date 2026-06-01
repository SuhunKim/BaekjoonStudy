using System;
using System.Collections.Generic; 
using System.Linq;


public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] {};
        
        //0,0   0,1     //빈칸 .
        //1,0   1,1     //파일 #  드래그 선택+삭제 가능
        //한번의 드래그로 모든파일을 삭제 - 최소한의 이동거리 즉 대각선의 길이가 제일짧은.
        
        //드래그 정의 : S(minX,minY)를 왼쪽클릭, E(MaxX, MaxY)로 이동
        //드래그 거리 |MaxX-minX| + |MaxY-minY|
        
        // . # . . .    S: 가장 왼쪽상단의 # or
        // . . # . .
        // . . . # .
        
        int minX=50;
        int minY=50;
        int MaxX=0;
        int MaxY=0;
        
//       Console.WriteLine(wallpaper.First().Length);
        for(int i =0 ; i<wallpaper.GetLength(0); i++){
            int Firstindex = wallpaper[i].IndexOf('#');
            int Lastindex = wallpaper[i].LastIndexOf('#');
     
            if(Firstindex==-1 ||Lastindex==-1 ){
                continue;
            }
            minX=Math.Min(minX,i);
            minY=Math.Min(minY,Firstindex);
            
            MaxX=Math.Max(MaxX,i);
            MaxY=Math.Max(MaxY,Lastindex);
            
        }
        
        
        Console.WriteLine(string.Format("minX,minY,MaxX,MaxY\n{0} {1} {2} {3}",minX,minY,MaxX+1,MaxY+1));
        
        
        
        
        
        
       answer = new int[] { minX, minY, MaxX + 1, MaxY + 1 };
        
        return answer;
    }
}