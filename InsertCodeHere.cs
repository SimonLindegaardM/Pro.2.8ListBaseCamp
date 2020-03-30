using System;
using System.Collections.Generic;
// ReSharper disable CollectionNeverQueried.Local

namespace ListBaseCamp
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> listOfInt = new List<int>();
            listOfInt.Add(4);
            listOfInt.Add(12);
            listOfInt.Add(9);

            // Case 1
            // Console.WriteLine($"Case 1: Element with index 1 is {listOfInt[1]}");

            // Case 2
            // Console.WriteLine($"Case 2: List contains {listOfInt.Count} elements");

            listOfInt.Add(5);
            listOfInt.Add(22);

            // Case 3
            // Console.WriteLine($"Case 3: Element with index 3 is {listOfInt[3]}");

            listOfInt.RemoveAt(0);

            // Case 4
            // Console.WriteLine($"Case 4: Element with index 3 is {listOfInt[3]}");



            listOfInt.Clear();
            listOfInt.Add(14);
            listOfInt.Add(87);
            listOfInt.Add(62);
            listOfInt.Add(21);
            listOfInt.Add(40);
            listOfInt.Add(3);

            // Case 5: Add code that prints out 
            // all the elements in the list
            // for (int index = 0; index < listOfInt.Count; index++ )
            // {
            //     Console.WriteLine(listOfInt[index]);
            // }
            foreach(var item in listOfInt)
            {
                Console.WriteLine(item);
            }
            System.Console.WriteLine("End of Case 5");
            System.Console.WriteLine();


            // Case 6: Add code that finds the 
            // sum of the elements in the list, and prints the result
            int Sum = 0;
            // for(int aa =0; aa<listOfInt.Count; aa++)
            // {   
            //     Sum+=listOfInt[aa];
            // }
            foreach(int i in listOfInt)
            {
                Sum = Sum + i;
            }
            System.Console.WriteLine($"The sum is {Sum}");

            System.Console.WriteLine($"The sum of the list is {listOfInt[0]+listOfInt[1]+listOfInt[2]+listOfInt[3]+listOfInt[4]+listOfInt[5]}");
            
            System.Console.WriteLine("End of Case 6");
            System.Console.WriteLine();

            // [DIFFICULT]
            // Case 7: Add code that finds the smallest  
            // element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually
            listOfInt.Sort();
            System.Console.WriteLine($"The smallest element is {listOfInt[0]}");
            System.Console.WriteLine("End of Case 7");
            System.Console.WriteLine();
            int smallest = listOfInt[0];
            foreach(int i in listOfInt)
            {
                if(i<smallest)
                {
                    smallest = i;
                }
            }

            // [(maybe) DIFFICULT]
            // Case 8: Add code that sorts the content of the list.
            // Tip: Think before you code...
            listOfInt.Sort();
            foreach(var item in listOfInt)
            {
                Console.WriteLine(item);
            }
            System.Console.WriteLine("End of Case 8");
            

            // The LAST line of code should be ABOVE this line
        }
    }
}