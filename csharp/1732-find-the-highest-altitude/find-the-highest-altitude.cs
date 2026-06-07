public class Solution {
    public int LargestAltitude(int[] gain) {
        // int preFix =0  ;
        
        // List<int> myList = new List<int>();
        // myList.Add(0);
        // for(int i = 0 ; i < gain.Length  ; i ++ ){
        //     preFix = preFix + gain[i];
        //     myList.Add(preFix);
        // }
        // int max = myList[0] ;
        // foreach( int a in myList){
        //     if(max < a){
        //         max = a;
        //     }
        // }
        // return max ;
        int currentCheck = 0 ; 
        int max = 0 ; 
        for(int i = 0 ; i < gain.Length; i ++){
            currentCheck += gain[i]; 
            max= Math.Max(currentCheck, max);
        }
        return max; 

        
    }
}