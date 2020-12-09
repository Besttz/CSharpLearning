using System;

public class Node
{
    public Node LeftChild { get; private set; }
    public Node RightChild { get; private set; }

    public Node(Node leftChild, Node rightChild)
    {
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public int Height()
    {
        return HeightOfNode(this);
    }

    /*
    public int HeightOfNode(Node node) {
        if (this.LeftChild == null && this.RightChild== null)
        {
             return 0;
        }
        int left = 0;
        int right = 0;
        if (this.LeftChild == null)
        {
            left = 0;
        } else {
            left = HeightOfNode(this.LeftChild) +1;
        }
        if (this.RightChild == null)
        {
            left = 0;
        } else {
            left = HeightOfNode(this.RightChild) +1;
        }
        
        if (left > right) return left;
        else return right;

    }
    */
    public int HeightOfNode(Node node)
    {
        if (node == null)
            return 0;
        else
        {
            int left = 0;
            int right = 0;
            if (node.LeftChild != null)
                left = HeightOfNode(node.LeftChild) + 1;

            if (node.RightChild != null) right = HeightOfNode(node.RightChild) + 1;

            /* use the larger one */
            if (left > right)
                return (left);
            else
                return (right);
        }

    }
    public static void Main(string[] args)
    {
        Node leaf1 = new Node(null, null);
        Node leaf2 = new Node(null, null);
        Node node = new Node(leaf1, null);
        Node root = new Node(node, leaf2);

        Console.WriteLine(root.Height());
    }
}