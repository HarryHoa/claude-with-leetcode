public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 !=0){
            return false;
        }
        Stack<char> a = new Stack<char>();
        foreach(char c in s ){
            if(c =='(' || c == '{' || c =='['){
                a.Push(c);
            }else{
                if(a.Count == 0 ){
                    return false ;
                }
                char top = a.Pop();
                if(c == ')'  && top != '(') return false;
                if(c == '}' && top != '{') return false;
                if(c == ']' && top != '[') return false ;
            }
        }
        return a.Count == 0 ;

    }
    
}