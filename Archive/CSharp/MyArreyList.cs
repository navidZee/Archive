using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp
{
    public static class MyArreyList
    {
        public static void CreateArreyList()
        {
            //http://vpaste.net/dzDWZ 
            //http://vpaste.net/VhLjw // main method 

            ArrayList arrayList = new ArrayList() { 100, "Two", 12.5, 200 }; //any type !


            #region ADD & AddRange & Insert & InsertRange

            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5);

            ArrayList arryList22 = new ArrayList();
            arryList22.Add(100);
            arryList22.Add(200);

            //adding entire arryList2 into arryList1
            arryList1.AddRange(arryList22);

            // Specific index
            arryList1.Insert(1, "Second Item"); 
            arryList1.Insert(2, 100);

            arryList22.InsertRange(2, arryList1);

            #endregion

            #region  AccessToArray

            ArrayList arryList2 = new ArrayList();
            arryList2.Add(1);
            arryList2.Add("Two");
            arryList2.Add(3);
            arryList2.Add(4.5f);

            //Access individual item using indexer
            int firstElement = (int)arryList2[0]; //returns 1
            string secondElement = (string)arryList2[1]; //returns "Two"
            int thirdElement = (int)arryList2[2]; //returns 3
            float fourthElement = (float)arryList2[3]; //returns 4.5

            //use var keyword
            var firstelementbyvar = arryList2[0]; //returns 1

            #endregion

            #region Navigate

            ArrayList arryList3 = new ArrayList();
            arryList3.Add(1);
            arryList3.Add("Two");
            arryList3.Add(3);
            arryList3.Add(4.5);

            foreach (var val in arryList3)
                Console.WriteLine(val);

            //Or
            for (int i = 0; i < arryList3.Count; i++)
                Console.WriteLine(arryList3[i]);

            #endregion

            #region Remove & RemoveAt & RemoveRange

            #region Remove
            ArrayList arryList4 = new ArrayList();
            arryList4.Add(100);
            arryList4.Add(200);
            arryList4.Add(300);
            arryList4.Remove(100); //Removes 1 from ArrayList
            foreach (var item in arryList4)
                Console.WriteLine(item);
            #endregion

            #region RemoveAt
            ArrayList arryList5 = new ArrayList();
            arryList5.Add(100);
            arryList5.Add(200);
            arryList5.Add(300);
            arryList5.RemoveAt(1);  // Specific index
            foreach (var item in arryList5)
                Console.WriteLine(item);
            #endregion

            #region RemoveRange
            ArrayList arryList6 = new ArrayList();
            arryList6.Add(100);
            arryList6.Add(200);
            arryList6.Add(300);
            arryList6.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            foreach (var item in arryList6)
                Console.WriteLine(item);
            #endregion

            #endregion

            #region Sort & Reverse
            ArrayList arryList7 = new ArrayList();
            arryList7.Add(300);
            arryList7.Add(200);
            arryList7.Add(100);
            arryList7.Add(500);
            arryList7.Add(400);

            Console.WriteLine("Original Order:");

            foreach (var item in arryList7)
                Console.WriteLine(item);

            arryList7.Reverse();
            Console.WriteLine("Reverse Order:");

            foreach (var item in arryList7)
                Console.WriteLine(item);

            arryList7.Sort();
            Console.WriteLine("Ascending Order:");

            foreach (var item in arryList7)
                Console.WriteLine(item);
            #endregion

            #region Contains
            ArrayList myArryList = new ArrayList();
            myArryList.Add(100);
            myArryList.Add("Hello World");
            myArryList.Add(300);
            Console.WriteLine(myArryList.Contains(100));
            #endregion

        }
    }
}
