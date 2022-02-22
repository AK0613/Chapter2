using System;
using System.Collections;
using System.Collections.Generic;

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
            int size = 7; 
            Random random = new();
            Console.Clear();
            Console.WriteLine("Problem 1: Write code to remove duplicates from a Linked List\n" +
                "For Linked List: ");

            
            LinkedList<int> ll = new LinkedList<int>();
            /*Populate linkedlist with random numbers
            for (int i = 0; i < size; i++)
            {
                ll.AddFirst(random.Next(1000));
            }*/

            ll.AddFirst(15);
            ll.AddFirst(20);
            ll.AddFirst(30);
            ll.AddFirst(30);
            ll.AddFirst(40);

            displayLL(ll);

            ll = DeleteDupes(ll);

            displayLL(ll);



        }

        static void displayLL(LinkedList<int> ll)
        {
            var iterator = ll.First;
            //Display linked list
            while (iterator != null)
            {
                Console.Write(iterator.Value + " ");
                iterator = iterator.Next;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Deletes the duplicate values in a linked list by iterating through the list and adding values to a hash table. If the value is 
        /// repeated then the linkedlist node is deleted
        /// </summary>
        /// <param name="n"></param>
        /// <returns>The linked list after deleting duplicates </returns>
        static LinkedList<int> DeleteDupes(LinkedList<int> n)
        {
            //Hash table to hold individual values as keys
            Hashtable ht = new();
            //Iterator equals the first list node
            var iterator = n.First;

            //While whithin the list
            while(iterator != null)
            {
                //If the hash table contains the same key as the iterator then remove it from the linked list and move to the next list item
                if(ht.Contains(iterator.Value))
                {
                    n.Remove(iterator.Value);
                    iterator = iterator.Next;
                }

                //Else add the value for the iterator to the hash table and move to the next node
                else
                {
                    ht.Add(iterator.Value, 1);
                    iterator = iterator.Next;
                }
            }

            return n; 
        }
        #endregion
    }
}