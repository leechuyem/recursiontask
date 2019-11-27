namespace Exercises {
    public class ListNode {
        public string Data;
        public ListNode Next;

        public ListNode (string data, ListNode next = null) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class LinkedList {
        public ListNode Head;

        public LinkedList () {
            Head = null;
        }

        public void AddToEnd (string newData) {
            ListNode newNode = new ListNode (newData, null);

            if (Head == null) {
                Head = newNode;
                return;
            }

            ListNode current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public ListNode GetNodeAt (int index) {
            int count = 0;

            if (index < 0) {
                return null;
            }

            ListNode current = Head;
            while (count < index) {
                if (current.Next != null) {
                    current = current.Next;
                } else {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find (string searchTerm) {
            ListNode current = Head;

            while (current != null) {
                if (current.Data == searchTerm) {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the number of nodes in the Linked List
        /// </summary>
        /// <returns>int: count</returns>
        public int Count () {
            int count = 0;

            ListNode current = Head;

            if (current.Data != null) {
                count++;

                while (current.Next != null) {
                    current = current.Next;
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Adds a node to the start of the list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>success: true</returns>
        public bool AddToStart (string data) {

            if (Head != null) {
                ListNode newNode = new ListNode (data, null);
                newNode.Next = Head;
                Head = newNode;

                return true;
            }

            return false;
        }

        /// <summary>
        /// add new node at index.  If index specified is greater than the size of the current list,
        /// adds nodes with null data in between.  Negative index will return false.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool AddNodeAt (string data, int index) {

            if (index < 0) {
                return false;
            }

            ListNode newNode = new ListNode (data, null);
            ListNode current = Head;

            int count = Count ();

            if (index < count) {
                

                int counter = 0;

                while (counter < index - 1) {
                    current = current.Next;
                    counter++;
                }

                ListNode nodesAfterIndex = GetNodeAt (index);
                newNode.Next = nodesAfterIndex;
                current.Next = newNode;
            } else {
                while(current.Next != null) {
                    current = current.Next;
                }

                while(index > count) {
                    current.Next = new ListNode(null, null);
                    current = current.Next;
                    index--;
                }
                current.Next = newNode;
            }

            return true;
        }

        /// <summary>
        /// Delete node at index.  return false if node does not exist
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteNodeAt (int index) {
            int count = Count(); 
            if(index < 0 || index >= count) {
                return false;
            }

            ListNode current = Head; 
            ListNode nextNode = GetNodeAt(index + 1); 
            int counter = 0; 

            while(counter < index - 1) {
                current = current.Next; 
                counter++; 
            }

            current.Next = nextNode;
            
            

            return true;
        }
    }
}