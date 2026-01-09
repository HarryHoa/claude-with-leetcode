# LeetCode 1469: Find


from typing import Optional, List, TreeNode

class Solution:
    def getLonelyNodes(self, root: Optional[TreeNode]) -> List[int]:
        """
        Find all lonely nodes in a binary tree.
        A lonely node is defined as a node that has exactly one child.

        Args:
            root: The root node of the binary tree

        Returns:
            A list containing values of all lonely nodes
        """

        def dfs(node: Optional[TreeNode]) -> None:
            """
            Depth-first search to traverse the tree and identify lonely nodes.

            Args:
                node: Current node being processed
            """
            # Base case: if node is None or node is a leaf (both children are None)
            if node is None or (node.left is None and node.right is None):
                return

            # Check if current node has only right child (left is None)
            if node.left is None:
                result.append(node.right.val)

            # Check if current node has only left child (right is None)
            if node.right is None:
                result.append(node.left.val)

            # Recursively traverse left subtree
            dfs(node.left)

            # Recursively traverse right subtree
            dfs(node.right)

        # Initialize result list to store lonely node values
        result = []

        # Start DFS traversal from root
        dfs(root)

        return result
