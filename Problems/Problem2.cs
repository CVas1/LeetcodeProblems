public class Problem2
{
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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        ListNode current = head;
        int carry = 0;
        while (true)
        {
            int sum = l1.val + l2.val + carry;
            current.val = (sum) % 10;
            carry = 0;
            if (sum >= 10) carry = 1;

            if (l1.next == null && l2.next == null && carry == 0) break;
            current.next = new ListNode();
            current = current.next;

            if (l2.next == null) l2.val = 0;
            else l2 = l2.next;
            if (l1.next == null) l1.val = 0;
            else l1 = l1.next;
        }

        // Console.WriteLine(head.val);
        // Console.WriteLine(head.next.val);
        // Console.WriteLine(head.next.next.val);
        // Console.WriteLine(head.next.next.next.val);
        // Console.WriteLine(head.next.next.next.next.val);
        // Console.WriteLine(head.next.next.next.next.next.val);
        // Console.WriteLine(head.next.next.next.next.next.next.val);
        // Console.WriteLine(head.next.next.next.next.next.next.next.val);
        return head;
    }
}