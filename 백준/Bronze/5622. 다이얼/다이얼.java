import java.io.*;
import java.util.*;
//import java.utill.Hash.map;
//import java.utill.map;

public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        String str = sc.nextLine();
        
        int answer = 0;

        for(int i=0; i<str.length(); i++){
            
            char c = str.charAt(i);

            switch(c){

                case 'A':                case 'B':                case 'C':
                    answer+=3;
                    break;
                case 'D':                case 'E':                case 'F':
                    answer+=4;
                    break;
                case 'G':                case 'H':                case 'I':
                    answer+=5;
                    break;
                case 'J':                case 'K':                case 'L':
                    answer+=6;
                    break;
                case 'M':                case 'N':                case 'O':
                    answer+=7;
                    break;
                case 'P':                case 'Q':                case 'R':         case 'S':
                    answer+=8;
                    break;
                
                case 'T':                case 'U':                case 'V':
                    answer+=9;
                    break;
                case 'W':                case 'X':case 'Y':case 'Z':
                    answer+=10;
                    break;
            }
        }

        System.out.println(answer);

        //Map<String, Integer> hashAtoNum = new HashMap<>();
        //Map<Integer, Integer> hashNumtoSec = new HashMap<>();
        //String[] arrAlpha = {"A","B","C","D","E","F","G","H","I","J",
        //"K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        //int [] arrNum = {2,2,2,3,3,3,4,4,4,5,5,5,6,6,6,7,7,7,7,8,8,8,9,9,9,9,0};
       
    }
}
