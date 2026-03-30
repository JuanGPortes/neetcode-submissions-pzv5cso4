public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {

        //Initialize the row * column size of the matrix
        int m = matrix.Length;
        int n = matrix[0].Length;
        //Initialize the starter node or position before starting traverse the matrix
        int rowPos = 0;
        int colPos = -1;
        //Initialize the direction to start traversing the matrix (start from left to right)
        int rowDir = 0;
        int colDir = 1;

        //Initialize the list where the matrix contents will be stored
        List<int> res = new List<int>();

        //Make a call of the recursive method wich will be used to traverse and estore the elements from the matrix
        Dfs(m, n, rowPos, colPos, rowDir, colDir, matrix, res);
        
        //return the result
        return res;
    }

    void Dfs(int rows, int cols, 
        int rowPos, int colPos, 
        int rowDir, int colDir,
        int[][] matrix, List<int> res){
            //verify that the rows and cols to traverse are not zero or lower 'cause you can't traverse an 
            //rectangle with no length or depth
            if(rows == 0 || cols == 0){
                return;
            }

            //Start traversing the matrix using the starting point and onwards on the given direction (to the right)
            for(int i = 0; i < cols; i++){
                //To start moving through the matrix add the rowPos + rowDir and colPos + colDir
                //This will mean that our current position wich each iteration will be increasing
                // or decreasing depending on the case in order to achieve the clockwise edges traverse
                //in the matrix
                rowPos += rowDir;
                colPos += colDir;
                //Get and add to the list the element in the position resulting from rowPos and colPos
                //because that's the resultant of our new position in the matrix
                res.Add(matrix[rowPos][colPos]);
            }
            
            //Call recursively the Dfs method but with changes in the position where some arguments will be passed
            //First, because we're using the variable cols within the method to dictaminate how many times
            //we're allowed to traverse through a section of the matrix in a direction, it'll be necessary
            //to swap how the arguments are passed, meaning that the argument cols will always receive 
            //the number of steps of the direction to travel, meaning i.e. if we're finished with the 
            //first row from left to right if we turn clockwise 90° that means that now we have to travel 
            //from top to bottom so we have to pas through the number of rows to traverse, but because previously
            //we've already traverse a section of the rows or cols depending of the case, that means that
            //now we would have a row or col -1 due to that one already traversed.
            //in summary pass throuh the rows and cols arguments and where the cols argumets should go 
            //subtract one.
            //The rowPos and rowDir pass without modifications, those positions have already been updated
            //within the for loop.
            //The direction arguments (rowDir and colDir) should also be swapped and we should send the one
            //going in the colDir position as a negative number that's how we'll rotate to traverse the matrix
            //let's say you finished in the positon (0,2) which is the last position left to right from the
            //top row that means the direction was (0,1) to the right in order to traverse top to bottom whe need
            //to add 1 and add nothig to the (0,2) positions but becauses there will be a case where we'll
            //need to decrease the number of the position where we'll be traveling i.e. from right to left
            //we need to pass through a negative number where the cols argument is.
            //Matrix and list pass through normal
            Dfs(cols,rows-1,rowPos,colPos,colDir,-rowDir,matrix,res);            
    }
}
