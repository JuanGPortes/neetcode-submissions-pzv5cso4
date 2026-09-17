public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int[] counts = new int[2];

        foreach(int student in students){
            counts[student]++;
        }

        foreach(int sandwich in sandwiches){
            if(counts[sandwich] > 0){
                counts[sandwich]--;
            }
            else{
                break;
            }
        }

        return counts[0] + counts[1];
    }
}