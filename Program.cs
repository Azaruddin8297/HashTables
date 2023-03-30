using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(0, "TO");
            h.Add(1, "BE");
            h.Add(2, "TO");
            h.Add(3, "NOT");
            h.Add(4, "TO");
            h.Add(5, "BE");

            foreach (DictionaryEntry ele in h)
            {
                Console.WriteLine("{0} and {1} ", ele.Key, ele.Value);
            }
            Console.WriteLine("*********************************************");
            Hashtable h1 = new Hashtable() { { 1, "Paranoids" } , { 2, "are" }, { 3, "Paranoid" },
            { 4, "because" } ,{ 5, "they" } ,{ 6, "Paranoid" } ,{ 7, "but" } ,{ 8, "because" } ,
            { 9, "they" } ,{ 10, "keep" } ,{ 11, "putting" } ,{ 12, "themselves" } ,{ 13, "deliberately" } ,
            { 14, "into" } ,{ 15, "Paranoid" } ,{ 16, "avoidable" } ,{ 17, "situations" } };
            foreach (DictionaryEntry ele1 in h1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            Console.WriteLine("*********************************************");
            h1.Remove(16);
            foreach (DictionaryEntry ele2 in h1)
            {
                Console.WriteLine("{0} and {1} ", ele2.Key, ele2.Value);
            }
        }
    }
}