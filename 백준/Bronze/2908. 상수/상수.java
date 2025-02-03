import java.io.*;
import java.util.*;

public class Main{
    
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        
        String strb = Integer.toString(b);
        String stra = Integer.toString(a);
        
        StringBuffer sb = new StringBuffer(strb);
        StringBuffer sba = new StringBuffer(stra);
        
        strb = sb.reverse().toString();
        stra = sba.reverse().toString();
        
        int sangsuA = Integer.parseInt(stra);
        int sangsuB = Integer.parseInt(strb);
        
        if( sangsuA > sangsuB){
            System.out.println(sangsuA);    
        }
        else{
            System.out.println(sangsuB);    
        }
        
        sc.close();
    }
}