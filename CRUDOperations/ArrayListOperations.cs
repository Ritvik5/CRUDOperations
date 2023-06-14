using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CRUDOperations
{
    public class ArrayListOperations
    {
        public ArrayList obj = new ArrayList();

        public void AddItems()
        {
            obj.Add(10);
            obj.Add(20);
            obj.Add(30);
            obj.Add("This is the fourth value.");
            obj.Insert(1, "This is the first index");
        }

        public void DisplayItems()
        {
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
        }

        public void UpdateItems()
        {
            if(obj.Contains(10))
            {
                obj.SetRange(0,new ArrayList() {"John"});
            }
            Console.WriteLine("\nAfter updating the ArrayLisyt.\n");
            DisplayItems();
            Console.WriteLine("\nCapacity: {0}\n",obj.Capacity);
        }

        public void DeleteItems()
        {
            obj.Remove("This is the first index");
            Console.WriteLine("After the Deleting the item .\n");
            DisplayItems();

        }
    }
}
