namespace LeetCodeDaily
{
    public class BinTreeFromDescriptions
    {
        //     public TreeNode CreateBinaryTree(int[][] descriptions)
        //     {
        //         var head = new TreeNode(descriptions[0][0]);
        //     }

        //     private TreeNode LCA (TreeNode node1, TreeNode node2)
        //     {

        //     }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}