import java.io.*;
import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        
        String org = sc.nextLine();
        sc.close();

        int start =0;
        int end = org.length()-1;
        
        int ans = 1;
        while(start<end){
            if(org.charAt(start) != org.charAt(end)){
                ans = 0;
                break;
            }
            start++;
            end--;
        }

        System.out.println(ans);





    }
}