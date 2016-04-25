using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22___Dynamic_Tree_Creation
{
	public class Tree
	{
		// Attributes.
		private Node root = null;

		// Properties.
		public Node Root
		{
			get { return this.root; }
		}
		
		// Methods.
		//  Insert
		public void Insert(int val)
		{
			// If there is no tree yet.
			if (root == null)
			{
				root = new Node(val);
			}
			else
			{
				Insert(val, root);
			}
		}

		private void Insert(int val, Node temp)
		{
			// Tree is not empty.
			int comparator = temp.Data;

			// If value is less than Data.
			if (val < comparator)
			{
				// Is left node available?
				if (temp.Left == null)
				{
					temp.Left = new Node(val);
				}
				// If not, go deeper.
				else
				{
					Insert(val, temp.Left);
				}

			}
			// If value is greater than or equal to data.
			else
			{
				// Is right node available?
				if (temp.Right == null)
				{
					temp.Right = new Node(val);
				}
				// If not, go deeper.
				else
				{
					Insert(val, temp.Right);
				}
			}
		}


		//  Print
		public void Print()
		{
			// Call the print method for the root level.
			int level = 0;
			Print(root, level);
		}

		private void Print(Node n, int level)
		{
			if (n != null)
			{
				// Print current data.
				for (int x = 0; x < level; x++)
				{
					Console.Write("|");
				}

				Console.WriteLine(n.Data);

				// Check left.
				if (n.Left != null)
				{
					Print(n.Left, (level + 1));
				}

				// Check right.
				if (n.Right != null)
				{
					Print(n.Right, (level + 1));
				}
			}
		}


	}
}
