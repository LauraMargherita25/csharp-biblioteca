using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Product
    {
        protected int runningTime;

        public Dvd(int code, string title, int releaseYear, string section, bool available, int rack, string author, int runningTime) : base(code, title, releaseYear, section, available, rack, author)
        {
            this.runningTime = runningTime;
        }
    }
}
