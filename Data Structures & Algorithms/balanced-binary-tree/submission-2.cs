/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root==null){
            return true;
        }
        int leftcount=height(root.left);
        int rightcount=height(root.right);
        

        if( Math.Abs(leftcount-rightcount)<=1){
            return IsBalanced(root.left)&&IsBalanced(root.right);
        }
        else{
            return false;
        }
        
    }

    public int height(TreeNode root){
        if(root==null){
            return 0;
        }
        int leftcount=height(root.left);
        int rightcount=height(root.right);

        return 1+Math.Max(leftcount,rightcount);
    }
}
