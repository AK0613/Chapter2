using System;
using System.Collections;

namespace Chapter2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? choice;
            int problem;

            Console.WriteLine("Problems from the book. Chapter 1");

            do
            {
                problem = Menu();
                switch (problem)
                {
                    case 1:
                        p1();
                        break;
                    /*case 2:
                        p2();
                        break;
                    case 3:
                        p3();
                        break;
                    case 5:
                        p5();
                        break;
                    case 6:
                        p6();
                        break;
                    case 7:
                        p7();
                        break;
                    case 8:
                        p8();
                        break;
                    case 9:
                        p9();
                        break;*/
                }


                Console.WriteLine("Would you like to try another problem? (Enter y or Y to proceed)");

                choice = Console.ReadLine();

            } while (choice == "y" || choice == "Y");
        }

        #region Menu
        static int Menu()
        {
            string? input;
            int problem;
            bool valid;

            Console.Clear();
            Console.WriteLine("Problem 1: Write code to remove duplicates from a Linked List\n" +
                "");

            do
            {
                Console.WriteLine("Please enter a number to select a problem: ");
                input = Console.ReadLine();
                valid = int.TryParse(input, out problem);
                if (!valid || problem > 10 || problem < 0)
                {
                    Console.WriteLine("Invalid input. You entered {0}", input);
                }

            } while (!valid || problem > 10 || problem < 0);

            return problem;
        }
        #endregion

        #region Problems
        static void p1()
        {

        }
        #endregion

        #region LinkedList Implementation

        //Class node used for the linked list
        class Node
        {
            internal Node? next = null;
            internal Node? prev = null;
            internal int data;

            public Node()
            {

            }

            public Node(int x)
            {
                data = x;
            }
        }

        //Class linkedList
        class LinkedList
        {
            private Node? head;
            private Node? tail;
            private Node? current;
            public int count;

            public LinkedList()
            {
                 head = new Node();
                 current = tail = head;
            }

            public void AddFirst(int x)
            {
                //If the head doesn't hold a value. Add a value to the head
                if (head.prev == null)
                    head.data = x;
                else
                {
                    Node? curr = new Node(x);
                    tail = curr;
                    current.next = head;
                    head.prev = curr;

                }
            }
        }
        #endregion
    }
}