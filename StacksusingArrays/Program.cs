/* Name: Katrina Coloso
 * Student Number: 2005-67067
 * March 17, 2019
 * Note: This C# Console program is an implementation of stacks using arrays. This console app lets you stack inputs through the following action: (1) enter the notebook's name which is the owner's name, check the notebook, peek at the most recent notebook added, check all the notebooks added, and exit the program.

 */
using System;

namespace StacksusingArrays
{
    class Program

    {
        interface StackKC
        {
            Boolean isEmpty();
            Boolean isNull();
            void daPush(Object element);
            Object daPop();
            Object daClean();
            Object daPeek();
            void daDisplay();
        }
        class myStack : StackKC
        {
            private int StackSize;

            public int StackSizeSet

            {
                /* returns variable count in my stack */
                get { return StackSize; }

                set { StackSize = value; }
            }

            public int top;

            /*adt */

            Object[] item;

            /* user input limit to 100 notebooks*/
            public myStack()
            {
                StackSizeSet = 100;

                /* describes stacksizeset as index size of 'item' array */

                item = new Object[StackSizeSet];

                /* 100 -1 = 0,1,2...99 */

                top = -1; // array counts from 0 
            }

            public myStack(int capacity) //capacity of the stack size
            {
                StackSizeSet = capacity;

                item = new Object[StackSizeSet]; 

                top = -1;
            }

            /* method to call to verify if stack is empty */
            public bool isEmpty()
            {
                if (top == -1) return true; // returns true if stack is empty and returns false if not
                return false;
            }

            /* method to call to push a variable in stack */
            public void daPush(object element)
            {
                if (top == (StackSize - 1)) // 100 -1 which array reads index from 0-99
                {
                    Console.WriteLine("Stack is full!");

                }
                else //if stack is not full, element entered can then be pushed
                {
                    item[++top] = element; //this code ++top increments the number of element stacked and then passed to "element" for data


                                        Console.WriteLine("Thank you for entering a notebook! It was added successfully!");
                }
            }
            public object daClean() // this method clears all elements in the stack
            {
                if (isEmpty()) //if stack is empty clearing of stack is not executed
                {
                    Console.WriteLine("No notebooks saved");
                    return "empty";
                }
                else  //if stack is not empty, clearing of stack can be executed
                {
                    return item = null; //item is then turned into null to empty 
                }
            }
            public bool isNull()
            {
                if (item == null)
                    return true;

                else
                {
                    return false; 
                }
            }

            /* method to call to pop a variable in stack */
            public object daPop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("No notebooks saved!");
                    return "empty";
                }

                else if (isNull())
                {
                    Console.WriteLine("No notebooks saved!");
                    return "empty";
                }
                else
                {
                    /*the item that is popped = top -1 */
                    return item[top--]; //the element is still retrievable but already popped in the stack
                }
            }


            public object daPeek() // retrieves and prints data from the top of the stack or the last element pushed to the stack
            {
                if (isEmpty()) // before exectuting the peek function, program checks first if stack is empty and returns "empty"
                {
                    Console.WriteLine("No notebooks saved!");
                    return "empty";
                }
                else if (isNull())
                {
                    Console.WriteLine("No notebooks saved!");
                    return "empty";
                }

                else  //else if not, it will execute peek function
                {
                    /* displays the top of item after a variable is popped = --top */
                    return item[top];
                }
            }
            public void daDisplay() //function that displays all elements in the stack
            {
                if (isEmpty())
                {
                    Console.WriteLine("No notebooks saved!");
                }

                else if (isNull())
                {
                    Console.WriteLine("No notebooks saved!");
                }

                else
                    /* loop scans every index, where top is represented by i, */
                    for (int i = top; i > -1; i--)
                    {
                        /* '(i+1)' reconstructs the index sequence from 0-99 to 1-100 */
                        Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
                    }
            }
        }

        /* THE MAIN OPERATION STARTS HERE */
        static void Main(string[] args)
        {
            myStack st = new myStack();
            /* to loop the menu */
            while (true)
            {
                Console.Clear(); //'clear' in array class method list
                Console.WriteLine("\nStack MENU(size -- 100)");
                Console.WriteLine("1. Add Notebook");
                Console.WriteLine("2. Check Notebook");
                Console.WriteLine("3. Peek at Notebook");
                Console.WriteLine("4. Check All");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");

                String choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":
                        Console.WriteLine("Enter the name of notebook : ");
                        st.daPush(Console.ReadLine());
                        break;


                    case "2":
                        if (st.isEmpty() || st.isNull())
                        {
                            Console.WriteLine("Please add a notebook.");
                        }

                        else
                        {
                            Console.WriteLine(st.daPop() + "'s notebook is being checked.");
                        }

                        break;

                    // below is same as case 2 

                    //case 3:

                    //Console.WriteLine("Element removed: {0}", st.daPop());

                    // break;

                    case "3":
                        Console.WriteLine("Top element is: {0}", st.daPeek());
                        break;

                    case "4":
                        st.daDisplay();
                        st.daClean();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;
                }

                Console.ReadKey();
            }

        }
    }
}