import java.io.*;
import java.util.*;

public class Main
{
    static int N; //정점 수
    static int M; //간선 수
    static int V; //시작 정점
    static int count;

    static int[][] arr;
    static boolean [] visited;
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        N= sc.nextInt();
        M= sc.nextInt();
        V=1;

        arr= new int[N+1][N+1];
        visited = new boolean[N+1];

        for(int i=0; i<M; i++){
         int a= sc.nextInt();
         int b= sc.nextInt();   
         
         arr[a][b]=arr[b][a]=1;
         
        }

        DFS(1);
        System.out.println(count);

    }
    public static void DFS(int start){
        visited[start]=true;
        
        for(int i=1; i<=N; i++){
            if(arr[start][i]== 1 && visited[i]==false){
                count++;
                DFS(i);
            }

        }
        
    }
}