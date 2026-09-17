public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> queue = new Queue<int>(students);
        int sandwichIdx = 0;
        int studentRejections = 0;

        while(queue.Count > 0 && studentRejections < queue.Count){
            if(queue.Peek() == sandwiches[sandwichIdx]){
                queue.Dequeue();
                sandwichIdx++;
                studentRejections = 0;
            }
            else{
                queue.Enqueue(queue.Dequeue());
                studentRejections++;
            }
        }
        return queue.Count;
    }
}