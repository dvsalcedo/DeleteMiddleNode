using System;

namespace DeleteMiddleNode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedLists linklist = new LinkedLists();
            linklist.append(1);
            linklist.append(2);
            linklist.append(3);
            linklist.append(4);
            linklist.append(5);
            linklist.append(6);
            linklist.append(7);
            linklist.append(8);

            linklist.print();
            DeleteNode(linklist, 5);          
            linklist.print();
        }

        static void  DeleteNode(LinkedLists list, int value)
        {
            var node = list.First();
            while(node != null){
                if(node.value == value){
                    node.value = node.next.value;
                    node.next = node.next.next;
                    break;
                }else{
                    node = node.next;
                }
            }
        }
    }
}
