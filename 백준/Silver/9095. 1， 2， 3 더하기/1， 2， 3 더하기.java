import java.io.*;
import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        
        int T = Integer.parseInt(sc.nextLine());
        //int T = sc.nextInt();
        
        for(int t=0; t<T; t++){
                    
        int n = sc.nextInt();    
                
        int[] dp = new int[11];
        
        dp[0]=1;
        dp[1]=2;
        dp[2]=4;
        
        for(int i =3; i<n; i++){
            dp[i] = dp[i-1] + dp[i-2] + dp[i-3];
        }
        
        System.out.println(dp[n-1]);
        
        
        
        }   
        sc.close();
        
        
    }
}