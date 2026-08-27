public class Solution {
    public int CalPoints(string[] operations) {
        if(operations.Length < 1){
            return 0;
        }

        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < operations.Length; i++)
        {
            string operation = operations[i];

            switch(operation)
            {
                case "+":
                    int top = stack.Pop();
                    int newTop = top + stack.Peek();

                    stack.Push(top);
                    stack.Push(newTop);
                break;
                case "D":
                    stack.Push(stack.Peek() * 2);
                break;
                case "C":
                    stack.Pop();
                break;
                default:
                    if(int.TryParse(operation, out int val))
                    {
                        stack.Push(val);
                    }
                break;
            }
        }

        int totalSum = 0;
        while(stack.Count > 0){
            totalSum += stack.Pop();
        }

        return totalSum;
    }
}