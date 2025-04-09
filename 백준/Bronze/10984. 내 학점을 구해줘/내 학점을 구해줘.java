import java.util.*;
import java.io.*;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int T = sc.nextInt();    //학기 수
        
            
        for(int i=0; i<T; i++){
            int N = sc.nextInt();    //과목 수
            
            int sumGrade = 0;
            float sumScore = 0;  
            
            for(int j=0; j<N; j++){              
                int grade = sc.nextInt();
                double score = sc.nextDouble();
                
                sumGrade += grade;
                sumScore += (score*grade);
            }
            System.out.println(sumGrade + " " + String.format("%.1f", (sumScore/sumGrade))) ;
        

        }
    }   
}
