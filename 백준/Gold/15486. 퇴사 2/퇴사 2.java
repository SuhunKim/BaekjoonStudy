import java.io.*;
import java.util.*;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        
        int[] term = new int[n + 2];
        int[] price = new int[n + 2];
        int[] dp = new int[n + 2];
        
        term[0]=0;
        price[0]=0;
        dp[0]=0;
        
        for (int i = 1; i <= n; i++) { // 1-indexed로 입력 받기
            term[i] = sc.nextInt();
            price[i] = sc.nextInt();
        }

        for (int i = 1; i <= n + 1; i++) {
            dp[i] = Math.max(dp[i], dp[i - 1]);

            if (i + term[i] <= n + 1) {
                dp[i + term[i]] = Math.max(dp[i + term[i]], dp[i] + price[i]);
            }
        }

        System.out.println(dp[n + 1]);
    }
}