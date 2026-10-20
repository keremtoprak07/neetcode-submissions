public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> s= new Stack<int>();

        foreach(String i in tokens){
            
            if((i!="+")&&(i!="-")&&(i!="*")&&(i!="/")){
                s.Push(int.Parse(i));
            }
            else{

                int result = 0;
                
                int o1=s.Pop();
            int o2=s.Pop();
            
            switch (i) {
                    case "+":
                        result = o1 + o2;
                        break;
                    case "-":
                        result = o2 - o1;
                        break;
                    case "*":
                        result = o1 * o2;
                        break;
                    case "/":
                        result = o2 / o1;
                        break;
            }
            s.Push(result);


            }
            
        }
        return s.Pop();
        

        
    }
}
