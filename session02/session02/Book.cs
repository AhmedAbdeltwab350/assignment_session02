using System;
using System.Collections.Generic;
using System.Text;

namespace session02
{
    internal class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"Book Title is {Title}, and the number of pages is {Pages}";
        }
    }
}
