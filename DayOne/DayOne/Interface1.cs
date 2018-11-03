using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    interface ICustomCollection
    {
        void Add(ICustomCollectionItem item);
        ICustomCollectionItem Crop(int index);
        ICustomCollectionItem GetAt(int index);
        void PrintAllValues();
    }

    interface ICustomCollectionItem
    {
        ICustomCollectionItem Next { get; set; }
        object Value { get; set; }
        int Index { get; set; }
    }
}
