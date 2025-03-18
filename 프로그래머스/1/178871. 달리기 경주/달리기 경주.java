import java.util.*;

class Solution {
    public String[] solution(String[] players, String[] callings) {
        String[] answer = new String[players.length];
        HashMap<String,Integer> hash = new HashMap<>();
        
        for(int i=0;i<players.length;i++){
            hash.put(players[i],i);
        }
        
        for(String call : callings){
            int callRank = hash.get(call);
            String tmp = players[callRank-1];
            players[callRank-1] = call;
            players[callRank] = tmp;
                
            hash.put(call/*players[callRank]*/,callRank-1);
            hash.put(tmp/*players[callRank]*/,callRank);
        }
        return players;
    }
}

 //// 이중 For문 시간초과
    //for (String calling : callings) {
    //    for (int i = 0; i < players.length; i++) {
    //        if (players[i].equals(calling)) {
    //            String temp = players[i - 1];
    //            players[i - 1] = players[i];
    //            players[i] = temp;
    //            break;
    //        }
    //    }
    //}
    //return players;