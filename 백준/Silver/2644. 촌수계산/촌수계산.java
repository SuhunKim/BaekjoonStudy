import java.io.*;
import java.util.*;

public class Main
{
    static int N;
    static int M;
    static int v1;
    static int v2;
    static int[] dist;

    static int[][] arr;
    static boolean[] visit;

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        N=sc.nextInt();
        v1= sc.nextInt();
        v2= sc.nextInt();
        M = sc.nextInt();

        arr= new int[N+1][N+1];
        dist = new int[N+1];
        visit= new boolean[N+1];

        for(int i=0; i<M; i++){
            int a= sc.nextInt();
            int b= sc.nextInt();

            arr[a][b]=arr[b][a]=1;
        }
        
        dist[v1]=0;
        DFS(v1,dist[v1]);
        
        if(dist[v2]==0){
            System.out.println(-1);
        }
        else{
            System.out.println(dist[v2]);
        }
        
    }
    public static void DFS(int start,int d){
      visit[start]=true;
      dist[start]=d;

      if(start==v2){
          return;
      }
      for(int i=0;i<=N;i++){
          if(!visit[i] && arr[start][i]==1){
              DFS(i,d+1);
          }

      }

    }
}