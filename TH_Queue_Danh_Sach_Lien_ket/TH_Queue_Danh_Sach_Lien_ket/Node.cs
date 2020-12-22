using System;
using System.Collections.Generic;
using System.Text;

namespace TH_Queue_Danh_Sach_Lien_ket
{
    class Node
    {
        public int key;
        public Node next;
        public Node(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
