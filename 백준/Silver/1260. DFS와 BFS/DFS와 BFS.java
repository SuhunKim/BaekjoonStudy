import java.util.LinkedList;
import java.util.Queue;
import java.io.*;
import java.util.*;

public class Main
{
    static boolean[] check;
    static int[][] arr;

    static int N;
    static int M ;
    static int V ;

    static Queue<Integer> q= new LinkedList<>();

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

         N = sc.nextInt();   // 정점 개수
         M = sc.nextInt();   // 간선 개수
         V = sc.nextInt();   // 시작 정점 번호
        
        arr = new int[N+1][N+1];
        check = new boolean[N+1];

        for(int i=0; i<M; i++){
            int a= sc.nextInt();
            int b= sc.nextInt();
            
            arr[a][b]=arr[b][a]=1;
        }
        
        DFS(V);
        System.out.println("");
        check = new boolean[N+1];
        BFS(V);

    }
    public static void DFS(int start){
        check[start]=true;  //방문함
        System.out.print(start+" ");
        for(int i=0;i<=N;i++){
            if(arr[start][i]== 1 && check[i]==false){
                DFS(i);
            }

        }

    }
    public static void BFS(int start){
        q.add(start);
        check[start]=true;

        while(!q.isEmpty()){
            start = q.poll();
            System.out.print(start+" ");

                for(int i=0;i<=N;i++){
                    if(arr[start][i]== 1 && check[i]==false){
                        q.add(i);
                        check[i]=true;
                    }

                }

        }

    }
}