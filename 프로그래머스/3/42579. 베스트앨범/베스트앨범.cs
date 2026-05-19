using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public int[] solution(string[] genres, int[] plays) {
        int[] answer = new int[] {};
        
        int count = genres.Length;  // 1~10000
        //장르의 종류가 여러개면 그 개수 최대*2만큼 리턴해야함  
        Dictionary<string,int> hashPlay = new Dictionary<string,int>(); //1. 장르별 재생 수 
        Dictionary<string,Dictionary<int,int>> hashMostPlayIndex = new Dictionary<string,Dictionary<int,int>>();    //2 장르별 Most >>> Key : 장르 , Value : (key고유번호,value 재생수)
        
        
        int iMostIndex=0;
        
        for(int i=0;i<count; i++){
            if(hashPlay.ContainsKey(genres[i]))
            {
                hashPlay[genres[i]]+=plays[i]; //장르의 재생 기록 
            }
            else{
                hashPlay[genres[i]]=plays[i] ;      //장르의 첫 재생수 기록
            }
            
            if(hashMostPlayIndex.ContainsKey(genres[i])){
                //hashMostPlayIndex[genres[i]].Add(new Dictionary<int, int>(){{genres[i],plays[i]} }) ; 
                hashMostPlayIndex[genres[i]].Add(i,plays[i] ) ; //고유번호,재생 수 를 추가
            }
            else{
                hashMostPlayIndex[genres[i]]=new Dictionary<int, int>(){{i,plays[i]} }; 
            }            
        }
        
        //장르(Key)를 재생(Value) 순으로 정렬
        var sortedGenres = hashPlay.OrderByDescending(x => x.Value).Select(x => x.Key);
        List<int> listBestAlbum = new List<int>();
        
        foreach (var genre in sortedGenres) //장르순으로 (최소 1~ 최대 2곡씩 뽑기)
        {
            // 2. 해당 장르의 [고유번호-재생수] 딕셔너리 가져오기
            Dictionary<int,int>   songsInGenre = hashMostPlayIndex[genre];
                
        var topSongs = songsInGenre
        .OrderByDescending(song => song.Value) // 재생수 큰 순
        .ThenBy(song => song.Key)              // 고유번호 작은 순
        .Take(2)                               // 최대 2개
        .Select(song => song.Key);             // 고유번호(Key)만 선택 
            //난이건못해 위LINQ
            listBestAlbum.AddRange(topSongs);
        }
         
            
        answer = listBestAlbum.ToArray();
        return answer;
    }
}