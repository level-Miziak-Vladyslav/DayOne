using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{

    class Creation: ICustomCollection
    {


        void ICustomCollection.Add(ICustomCollectionItem item)
        {
            throw new NotImplementedException();
        }

        ICustomCollectionItem ICustomCollection.Crop(int index)
        {
            throw new NotImplementedException();
        }

        ICustomCollectionItem ICustomCollection.GetAt(int index)
        {
            throw new NotImplementedException();
        }

        void ICustomCollection.PrintAllValues()
        {
            throw new NotImplementedException();
        }
    }
    class TheElement : ICustomCollectionItem
    {
        ICustomCollectionItem n;
        object v;
        int ind;
        public ICustomCollectionItem Next
        {
            get { return n; }
            set { n = value; }
        }
        public object Value
        {
            get { return v; }
            set { v = value; }
        }
        public int  Index
        {
            get { return ind; }
            set { ind = value; }
        }
        public TheElement()
        {
            Index = 0;
            Next = null;
            Value = "object # " + (Index + 1).ToString();
        }
        public TheElement(ICustomCollectionItem it)
        {
            Index = it.Index +1;
            it.Next = this;
            Next = null;
            Value = "object # " + (Index + 1).ToString();
        }
    }
}
