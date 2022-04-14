using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class PhotoBook
    {
        private int numPages;

        public int GetNumberPages()
        {
            return numPages;
        }

        public PhotoBook():this(16)
        {
            //numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
    }
}
