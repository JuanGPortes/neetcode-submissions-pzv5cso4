public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        if(points == null || points.Length <= k){
            return points;
        }

        Array.Sort(points, (a, b) => {
            int distanceA = (a[0] * a[0]) + (a[1] * a[1]);
            int distanceB = (b[0] * b[0]) + (b[1] * b[1]);
            
            return distanceA.CompareTo(distanceB);
        });

        int[][] result = new int[k][];
        Array.Copy(points, 0, result, 0, k);

        return result;
    }
}
