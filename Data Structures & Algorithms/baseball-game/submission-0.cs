public class Solution {
    public int CalPoints(string[] operations) {
        if(operations.Length < 1){
            return 0;
        }

        int totalSum = 0;
        List<int> records = new List<int>();

        for(int i = 0; i < operations.Length; i++){
            string value = operations[i];
            int result;
            if(int.TryParse(value, out result)){
                records.Add(result);
                totalSum += result;
            }
            else{
                switch(value){
                    case "+":
                    result = records[records.Count - 1] + records[records.Count - 2];
                    records.Add(result);
                    totalSum += result;
                    break;
                    case "C":
                    totalSum -= records[records.Count - 1];
                    records.RemoveAt(records.Count - 1);
                    break;
                    case "D":
                    result = 2 * records[records.Count - 1];
                    records.Add(result);
                    totalSum += result;
                    break;
                }
            }
        }

        return totalSum;
    }
}