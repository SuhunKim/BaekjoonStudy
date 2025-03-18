import java.util.*;

class Solution {
    public String solution(String[] participant, String[] completion) {
        String answer = "";
        
        Arrays.sort(participant);
        Arrays.sort(completion);
        
        for(int i=0; i< completion.length;i++){
            if(!participant[i].equals(completion[i])){
                return participant[i];
            }
            else{
            }
        }
        
   
        return participant[completion.length];
    }
}
     //// 중복해결 실패
        //HashMap<String,Boolean> hash = new HashMap<>();
        //
        //for(String people : participant){
        //    hash.put(people,false);            
        //}
        //
        //for(String people : completion){
        //    hash.put(people,true);
        //}
        //        
        //
        //for(String people : participant){
        //    Boolean bX = hash.get(people);
        //    if(bX==false){
        //        answer = people;
        //        break;
        //    }
        //}
        //