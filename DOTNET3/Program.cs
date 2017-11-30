using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {2, 4, 7, 1};
            Queue<int> queue = new Queue<int>(new int[] {1,2,3,4});
            Stack<int> stack = new Stack<int>(new int[] {1,2,3,4});

            Console.WriteLine(GetSumOfElements(list));
            Console.WriteLine(GetSumOfElements(queue));
            Console.WriteLine(GetSumOfElements(stack));

            Console.WriteLine(MagicMethod(list));

            ItemContainer container = new ItemContainer();
            container.Add(new Item("SuperItem"));

            Console.ReadKey();
        }

        static int GetSumOfElements(IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (int currentElement in collection)
            {
                sum += currentElement;
            }

            return sum;

        }

        static string MagicMethod(ICollection<int> collection)
        {
            return String.Empty;
        }

        class ItemContainer : List<Item>
        {
            private int idsUsed;
            
            public new void Add(Item item)
            {
                base.Add(item);
                item.ID = idsUsed;
                idsUsed++;
            }
        }
        class Item
        {
            public string Value;
            public int ID;

            public Item(string value)
            {
                Value = value;
            }
        }
    }
}
