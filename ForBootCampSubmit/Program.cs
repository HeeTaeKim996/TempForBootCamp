using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace hellWorld
{
    public class Mycollection<T>
    {
        public List<T> list = new List<T>();

        public void Add(T newValue)
        {
            list.Add(newValue);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public int Count()
        {
            return list.Count;
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }

    internal class Test
    {
        static void Main(String[] args)
        {
            Mycollection<String> collection = new Mycollection<string>();

            collection.Add("Hello");
            collection.Add("World");
            collection.Add("Bye");
            Console.WriteLine(collection[0]);

            collection.RemoveAt(1);
            Console.WriteLine(collection[1]);

            collection[0] = "Hell";
            Console.WriteLine(collection[0]);



            Mycollection<int> collectionInt = new Mycollection<int>();

            collectionInt.Add(12);
            collectionInt.Add(23);

            Console.WriteLine(collectionInt[1]);

        }
    }
}