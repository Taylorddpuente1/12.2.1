using System;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode current = dummy;

        while (current.next != null)
        {
            if (current.next.val == val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return dummy.next;
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        // Build the list: [1, 2, 6, 3, 4, 5, 6]
        ListNode head = new ListNode(1,
            new ListNode(2,
            new ListNode(6,
            new ListNode(3,
            new ListNode(4,
            new ListNode(5,
            new ListNode(6)))))));

        int valToRemove = 6;
        Solution solution = new Solution();
        ListNode newHead = solution.RemoveElements(head, valToRemove);

      
        PrintList(newHead);
    }

    
    private static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null) Console.Write(" -> ");
            node = node.next;
        }
        Console.WriteLine();
    }
}