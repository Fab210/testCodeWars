using System;
using System.Collections.Generic;

namespace testCodeWars
{
    class Program
    {

        // GET INTEGERS FROM A LIST
        // ______________________________________________________________________________
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            // create new INT List
            List<int> test = new List<int>();

            // loop listOfItems
            foreach (var item in listOfItems)
            {
                var itemType = item.GetType().Name;

                // IF item Type is int32 add into new List
                if (itemType == "Int32")
                {
                    test.Add((int)item);
                }
 
            }

            // return new List with only Integers
            return test;
        }


        // HIDE 4 LAST CHARACTERS FROM STRING
        // ______________________________________________________________________________
        public static string Maskify(string cc)
        {
            // convert string into array
            char[] array = cc.ToCharArray();

            // count length of array - 4
            int lenght = cc.Length - 4;

            // replace char from list with # but not the 4 last char
            for (int i = 0; i < lenght; i++)
            {
                array[i] = '#';

            }

            // convert array into string
            string s = new string(array);

            //return string
            return s;
        }


        // FIND NEXT SQUARE
        // ______________________________________________________________________________
        public static long FindNextSquare(long num)
        {
            // calcul square of given number
            double val = Math.Sqrt(num);

            // if result is a int and not decimal (add + 1 and multiple val *2) 
            if (val % 1 == 0)
            {
                val = val + 1;
                val = val * val;
            }else
            {
                return -1;
            }
            
            return (long)val;
        }
        static void Main(string[] args)
        {
            FindNextSquare(155);
            //Maskify("4556364607935616");
            //GetIntegersFromList(new List<object>() { 1, 2, "a", "b" });
            //GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 });
            //GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 });
        }
    }

}
