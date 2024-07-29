using System.Collections;
using System.Linq;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Advanced02
{
    internal class Program
    {
        public static void Reversse( ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            // near to Queue
            while (left < right)
            {
                
                object? temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }

        public static List<int> EvenNumbers(List<int> list) 
        {
            List<int> newarray = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2==0)
                {
                    newarray.Add(list[i]);
                }
            }
            return newarray;
        }
        static void Main(string[] args)
        {
            #region Part 01
            // Collections divide into (Non Generic Collections) and (Generic Collections)//

            //Non Generic Collections : Arraylist , SortedArray , Stack , Queue , Hashtable

            //Generic Collections : Lists , Hashtable

            #region Non Generic (Arraylist)
            // It is a dynamic array means the size of the array is not fixed, it can increase and decrease at runtime and can accept deffrend date.

            //Example
            ArrayList NonGenericArrayList = new ArrayList();
            string str = "Like, Share, Subscribe";

            int x = 11;

            DateTime d = DateTime.Parse("3-dec-1998");

            NonGenericArrayList.Add(str);

            NonGenericArrayList.Add(x);

            NonGenericArrayList.Add(d);

            //Time Complexity
            //Best and average case is O(1)
            //Worst case is O(n)
            #endregion

            #region Generic Lists
            //It is a dynamic array that provides functionality similar to that found in the non-generic ArrayList class.

            List<int> firstlist = new List<int>();

            // adding elements in firstlist 
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + firstlist.Count);

            //Time Complexity Access by index
            //  Best Case   Average Case    Worst Case
            //     O(1)	       O(1)	           O(1)



            #endregion

            #region other lists(LinkedList , Stack , Queue)

            #region LinkedList
            //It allows fast inserting and removing of elements. It implements a classic linked list.
            LinkedList<String> myList = new LinkedList<String>();

            // Adding nodes in LinkedList 
            myList.AddLast("Geeks");
            myList.AddLast("for");
            myList.AddLast("Data Structures");
            myList.AddLast("Noida");

            //Time Complexity 
            //Operation	                     Best Case	          Average Case   Worst Case
            //Accessing an element by index     O(n)                    O(n)       O(n)
            //Searching for an element          O(1)(if first)          O(n)       O(n)
            //Inserting an element              O(1) (at the beginning)	O(n)       O(n)
            //Deleting an element               O(1) (if head or tail)	O(n)       O(n)
            #endregion

            #region Stack
            //It is a first-in, last-out list and provides functionality similar to that found in the non-generic Stack class.

            Stack<int> myStack = new Stack<int>();

            // Push elements onto the stack
            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(7);

            // Peek at the top element
            Console.WriteLine("Top element: " + myStack.Peek());

            // Pop elements from the stack
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }

            //Time Complexity 
            //  Stack<T> Push    O(1)    O(1)    O(1)
            //     Pop           O(1)     O(1)    O(1)
            //     peek           O(1)	 O(1)    O(1)

            #endregion

            #region Queue	
            //A first-in, first-out list and provides functionality similar to that found in the non-generic Queue class.

            Queue<int> myQueue = new Queue<int>();

            // Enqueue elements
            myQueue.Enqueue(3);
            myQueue.Enqueue(5);
            myQueue.Enqueue(7);

            // Peek at the front element
            Console.WriteLine("Front element: " + myQueue.Peek());

            // Dequeue elements
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            //Time Complexity 
            // Enqueue O(1)	O(1)    O(1)
            //Dequeue O(1)	O(1)    O(1)
            //Peek    O(1)	O(1)    O(1)
            #endregion

            #endregion

            #region Dictionary<TKey,TValue>
            //It stores key/value pairs and provides functionality similar to that found in the non-generic Hashtable class.

            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine($" {ele1.Key}, {ele1.Value}");
            }
            // Operation                      Best Case                     Average Case            Worst
            // Dictionary<TKey, TValue>      Add/ Remove  O(1)(average)    O(1)(average)    O(n)(worst case, collisions)
            //  Lookup                             O(1)               (average)O(1)(average)   O(n)(worst case, collisions)
            #endregion

            #region HashSet<T>
            //It is an unordered collection of the unique elements.It prevent duplicates from being inserted in the collection.
            HashSet<int> odd = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                odd.Add(2 * i + 1);
            }


            // Operation                      Best Case                     Average Case            Worst
            // Dictionary<TKey, TValue>      Add/ Remove  O(1)(average)    O(1)(average)    O(n)(worst case, collisions)
            //  Lookup                             O(1)               (average)O(1)(average)   O(n)(worst case, collisions)
            #endregion

            #region SortedList<TKey,TValue>
            //It is a sorted list of key/value pairs and provides functionality similar to that found in the non-generic SortedList class.

            SortedList my_slist1 = new SortedList();

            
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");
            my_slist1.Add(1.01, "Tutorial");

            //Operation        Best Case    Average Case  Worst Case
            //Access by index    O(1)          O(1)        O(1)
            //Adding =          O(log n)    O(log n)       O(n)
            //Removing           O(log n)    O(log n)      O(n)
            //Searching          O(log n)    O(log n)    O(log n)
            #endregion


            #endregion

            #region Part 02

            #region (1)
            //ArrayList mylist = new ArrayList { 1, 2, 3, 4, 5 };
            //Reversse(mylist);

            //for (int i = 0; i < mylist.Count; i++)
            //{
            //    Console.WriteLine(mylist[i]);
            //} 
            #endregion

            #region (2)
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 8, 9, 71, 0, 2 };


            //List<int> newlist = EvenNumbers(list);


            //foreach (var item in newlist)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region (3)


            FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);


            fixedSizeList.AddElementToTheList(5);

            Console.WriteLine(fixedSizeList.GetElementAtSpecificIndex(0)); // 5

            Console.WriteLine(fixedSizeList.TheFirstNonRepeatedCharacter("mohamed")); // 1 



            #endregion

            #endregion
        }
    }
}
