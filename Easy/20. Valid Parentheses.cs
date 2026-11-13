public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();

        foreach (char c in s){
            if (c == '(' || c == '{' || c == '['){
                stack.Push(c);
            }
            else {
                if(stack.Count == 0){
                    return false;
                }

                char top = stack.Pop();

                if ((top != '(' && c == ')') ||
                    (top != '{' && c == '}') || 
                    (top != '[' && c == ']')){
                        return false;
                    }
            }
        }
        return stack.Count == 0;
    }
}
