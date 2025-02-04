import java.io.*;
import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int k=sc.nextInt();
        int q=sc.nextInt();
        int l=sc.nextInt();
        int b=sc.nextInt();
        int kn=sc.nextInt();
        int p=sc.nextInt();

        int [] correct = {1,1,2,2,2,8};
        correct[0]-=k;
        correct[1]-=q;
        correct[2]-=l;
        correct[3]-=b;
        correct[4]-=kn;
        correct[5]-=p;
        
        
        for(int i=0; i<correct.length; i++){
            System.out.print(correct[i]);
            if(i<correct.length-1){
                System.out.print(" ");
            }
        }



    }
}