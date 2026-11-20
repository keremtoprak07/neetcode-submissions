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
    public TreeNode InvertTree(TreeNode root) {
        if(root==null) return null;

        Queue<TreeNode> q= new Queue<TreeNode>();

        q.Enqueue(root);


        while(q.Count>0){
            TreeNode curr=q.Dequeue();

            TreeNode temp=curr.left;
            curr.left=curr.right;
            curr.right=temp;

            if(curr.left!=null) q.Enqueue(curr.left);
            if(curr.right!=null) q.Enqueue(curr.right);

        }
        return root;

        
        
    }
}
