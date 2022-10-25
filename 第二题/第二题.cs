public int[] Demo(TreeNode root)
	{
		if (root == null)
		{
			return new int[0];
		}
		bool isAdd = true;
		IList<int> res = new List<int>();
		Queue<TreeNode> queue = new Queue<TreeNode>();
		Queue<TreeNode> sonQueue = new Queue<TreeNode>();
		queue.Enqueue(root);
		while (queue.Count > 0)
		{
			TreeNode node = queue.Dequeue();
		        if (isAdd)
		       {
				res.Add(node.val);
				isAdd = false;
			}
			if (node.left != null)
			{
				sonQueue.Enqueue(node.left);
			}
			if (node.right != null)
			{
				sonQueue.Enqueue(node.right);
			}
			//将子节点队列赋值给父节点队列
			if(queue.Count == 0)
            {
				for (int i = 0; i < sonQueue.Count; i++)
				{
					queue.Enqueue(sonQueue.Dequeue());
				}
				isAdd = true;
			}
		}
		return res.ToArray();
	}
