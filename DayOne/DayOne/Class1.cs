using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{

    class Creation: ICustomCollection
    {
        ICustomCollectionItem lastIndex;
        ICustomCollectionItem StartElement;
        public Creation()
        {
            lastIndex = new TheElement();
            lastIndex.Index = 0;
            lastIndex.Next = null;
            lastIndex.Value = "start object # " + (lastIndex.Index).ToString();
            StartElement = lastIndex;
            Console.WriteLine(StartElement.Value.ToString() + "  index = " + StartElement.Index.ToString()+ " was added");
        }
        void ICustomCollection.Add(ICustomCollectionItem item)
        {
            item.Index = lastIndex.Index+1;
            lastIndex.Next = item;
            lastIndex = item;
            Console.WriteLine(lastIndex.Value.ToString() + "  index = " + lastIndex.Index.ToString() + " was added");

        }

        ICustomCollectionItem ICustomCollection.Crop(int index)
        {
            ICustomCollectionItem z = StartElement;
            ICustomCollectionItem x = StartElement;
            if (index >= lastIndex.Index)
            {
                for (int i = 0; i < lastIndex.Index; i++)
                {
                    x = z;
                    z = x.Next;
                }
                lastIndex = x;
                return z;
            }
            if (index <= 0)
            {
                z = StartElement;
                StartElement = StartElement.Next;
                x = z;
            }
            else
            {
                while (z.Index != index)
                {
                    x = z;
                    z = z.Next;
                }
                x.Next = z.Next;
            }
            for (int j = x.Next.Index; j < (lastIndex.Index + 1); j++)
                {
                    x.Next.Index = x.Next.Index - 1;
                    x = x.Next;
                }
                lastIndex = x;
            
            Console.WriteLine(z.Value.ToString() + "  index = " + z.Index.ToString() + " was cropped");
            return z;
        }

        ICustomCollectionItem ICustomCollection.GetAt(int index)
        {
            if (index > lastIndex.Index) return null;
            ICustomCollectionItem z = StartElement;
            int i = lastIndex.Index;
            while (z.Index != index)
            {
                z = z.Next;
            }
            return z;
        }
        void ICustomCollection.PrintAllValues()
        {
            ICustomCollectionItem z = StartElement;
            int i = lastIndex.Index;
            while (i != -1)
            {
                Console.WriteLine(z.Value.ToString()+ "  index = " + z.Index.ToString());
                z = z.Next;
                i--;
            }
        }
    }
    class TheElement : ICustomCollectionItem
    {
        public ICustomCollectionItem Next { get; set; }
        public object Value { get; set; }
        public int Index { get; set; }
        public TheElement()
        {
            Index = 0;
            Next = null;
            Value = "object # " + (Index + 1).ToString();

        }
    }
}
