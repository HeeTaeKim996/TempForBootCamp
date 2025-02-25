

namespace hellWorld
{
    public class Mycollection
    {
        public List<string> list = new List<string>();

        public void Add(string newString)
        {
            list.Add(newString);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public int Count()
        {
            return list.Count;
        }

        public string this[int index]
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
            Mycollection collection = new Mycollection();

            collection.Add("Hello");
            collection.Add("World");
            collection.Add("Bye");
            Console.WriteLine(collection[0]);

            collection.RemoveAt(1);
            Console.WriteLine(collection[1]);

            collection[0] = "Hell";
            Console.WriteLine(collection[0]);
        }
    }
}