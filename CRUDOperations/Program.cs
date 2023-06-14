namespace CRUDOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To CRUD operations on ArrayList and Dictionary Collection!!!\n");

            //ArrayListOperations arrayList = new ArrayListOperations();

            //arrayList.AddItems();
            //arrayList.DisplayItems();
            //arrayList.UpdateItems();
            //arrayList.DeleteItems();

            DictionaryOperations dictionary = new DictionaryOperations();

            dictionary.AddValues();
            dictionary.UpdateValues();
            dictionary.RemoveValues();
        }
    }
}