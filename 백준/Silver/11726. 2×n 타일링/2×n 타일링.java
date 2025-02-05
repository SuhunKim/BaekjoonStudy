import java.io.*;
import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        sc.close();

        long[] dp = new long[1000];

        dp[0]=1;
        dp[1]=2;
        //dp[3]= 2*2*2;

        for(int i=2; i<n;i++){
            dp[i] = (dp[i-1]+dp[i-2])%10007;

            
        }

//
        long answer = dp[n-1]%10007;
        System.out.println(answer);
    }
}