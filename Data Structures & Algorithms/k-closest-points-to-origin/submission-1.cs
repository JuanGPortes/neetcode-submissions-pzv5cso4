public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        if(points == null || points.Length <= k){
            return points;
        }

        int left = 0;
        int right = points.Length - 1;

        while(left <= right){
            int pivotIndex = Partition(points, left, right);

            if(pivotIndex == k){
                break;
            }
            
            if(pivotIndex < k){
                left = pivotIndex + 1;
            }
            else{
                right = pivotIndex - 1;
            }
        }

        int[][] result = new int[k][];
        Array.Copy(points, 0, result, 0, k);
        return result;
    }

    private int Partition(int[][] points, int left, int right){
        int[] pivot = points[right];
        int pivotDistance = Distance(pivot);
        int pivotIndex = left;

        for(int i = left; i < right; i++){
            if(Distance(points[i]) <= pivotDistance){
                Swap(points, pivotIndex, i);
                pivotIndex++;
            }
        }

        Swap(points, pivotIndex, right);

        return pivotIndex;
    }

    private int Distance(int[] point){
        return (point[0] * point[0]) + (point[1] * point[1]);
    }

    private void Swap(int[][] points, int i, int j){
        int[] temp = points[i];
        points[i] = points[j];
        points[j] = temp;
    }
}
