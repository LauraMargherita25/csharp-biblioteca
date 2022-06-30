using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Product
    {
        protected int nPage;

        public Book (int code, string title, int releaseYear, string section, bool available, int rack, string author, int nPage) : base(code, title, releaseYear, section, available, rack, author)
        {
            this.nPage = nPage;
        }
    }
}
