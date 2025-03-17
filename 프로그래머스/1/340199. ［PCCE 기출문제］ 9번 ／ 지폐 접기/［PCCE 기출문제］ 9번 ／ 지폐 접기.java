class Solution {
    public int solution(int[] wallet, int[] bill) {
        int answer = 0;
        
        //boolean bput = false;
            int walletMin = Math.min(wallet[0],wallet[1]);
            int walletMax = Math.max(wallet[0],wallet[1]);
            
            int billMin = Math.min(bill[0],bill[1]);
            int billMax = Math.max(bill[0],bill[1]);
        
        while(true){
            
            if((walletMin>=billMin && walletMax>=billMax)||(walletMin>=billMax && walletMax>=billMin)){
                break;
            }
            if(billMax>walletMin ||billMax>walletMax){
                billMax/=2;
                if(billMax<billMin){
                    int tmp=billMax;
                    billMax=billMin;
                    billMin=tmp;
                }
                
            }
            
            answer+=1;
        }
        
        return answer;
    }
}