import java.io.*;
import java.util.*;

public class Main{
public static void main(String[] args){

    Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        sc.close();
//    long temp=0;
//    long [] arr = new int[n];
//
//    arr[0]=0;
//    arr[1]=1;
//
//    for(int i=2; i<n; i++){
//        arr[i]=arr[i-1] + arr[i-2];
//    }  
//    System.out.println(arr[n-1]);
    
        long[] fibo = new long[n + 1];
        fibo[0] = 0;
        fibo[1] = 1;

        for (int i = 2; i <= n; i++) {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }

        System.out.println(fibo[n]);
}


}