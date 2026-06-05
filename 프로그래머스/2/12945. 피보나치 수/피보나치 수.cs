public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // 점화식을 적용할 배열 선언
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;

        // 점화식: F(i) = F(i-1) + F(i-2)
        for (int i = 2; i <= n; i++)
        {
            dp[i] = (dp[i - 1] + dp[i - 2])%1234567;
        }
        
        answer = dp[n];//%1234567;
        return answer;
    }
}