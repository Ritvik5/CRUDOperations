using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperations
{
    public class DictionaryOperations
    {
        Dictionary<string,int> myValues = new Dictionary<string,int>();

        public void AddValues()
        {
            myValues.Add("First", 1);
            myValues.Add("Second", 2);
            myValues.Add("Third", 3);
            myValues.Add("Fourth", 4);
            myValues.Add("Fifth", 5);
            DisplayValues();
        }

        public void DisplayValues() 
        {
            foreach (KeyValuePair<string,int> item in myValues)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

        public void UpdateValues()
        {
            if (myValues.ContainsKey("Fifth"))
            {
                myValues["Fifth"] = 8;
            }
            if (myValues.ContainsValue(4))
            {
                myValues["Fourth"] = 6;
            }
            Console.WriteLine("\nAfter Updating Element in Dictionary.\n ");
            DisplayValues();
        }

        public void RemoveValues()
        {
            if (myValues.ContainsKey("Fifth"))
            {
                myValues.Remove("Fifth");
            }
            Console.WriteLine("\nAfter Removing the element in Dictionary.\n ");
            DisplayValues();

        }
    }
}
