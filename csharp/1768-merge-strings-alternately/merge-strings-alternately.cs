public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int s1 = 0 ; 
        int s2 = 0 ; 
        while(s1 < word1.Length || s2 < word2.Length){
          if(s1 < word1.Length){
            sb.Append(word1[s1]);
            s1++;
          }
          if(s2< word2.Length){
            sb.Append(word2[s2]);
            s2++;
          }
        }
        return sb.ToString();
    }
}