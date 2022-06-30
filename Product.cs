using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Product
    {
        protected int code;
        protected string title;
        protected int releaseYear;
        protected string section;
        protected bool available;
        protected int rack;
        protected string author;

        public Product (int code, string title, int releaseYear, string section, bool available, int rack, string author)
        {
            this.code = code;
            this.title = title;
            this.releaseYear = releaseYear;
            this.section = section;
            this.available = available;
            this.rack = rack;
            this.author = author;
        }
    }
}
