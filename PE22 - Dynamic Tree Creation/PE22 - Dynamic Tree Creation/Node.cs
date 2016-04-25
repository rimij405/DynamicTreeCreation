using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22___Dynamic_Tree_Creation
{
	public class Node
	{
		// Attributes.
		private Node left;
		private Node right;
		private int data;

		// Properties.
		public Node Left
		{
			get { return this.left; }
			set { this.left = value; }
		}

		public Node Right
		{
			get { return this.right; }
			set { this.right = value; }
		}

		public int Data
		{
			get { return this.data; }
		}

		// Constructor.
		public Node(int val)
		{
			data = val;
			left = null;
			right = null;
		}
	}
}
