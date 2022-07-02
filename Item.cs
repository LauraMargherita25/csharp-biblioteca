using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{

    internal class Item
    {
        public string Code { get; protected set; }
        public string Title { get; protected set; }
        public int ReleaseYear { get; protected set; }
        public string Section { get; protected set; } 
        public bool Available { get; protected set; }  
        public int Rack { get; protected set; }   
        public string Author { get; protected set; }

        public Item (string code, string title, int releaseYear, string section, bool available, int rack, string author)
        {
            this.Code = code;
            this.Title = title;
            this.ReleaseYear = releaseYear;
            this.Section = section;
            this.Available = available;
            this.Rack = rack;
            this.Author = author;
        }   

    }
}
