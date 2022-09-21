using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    public class File
    {
        protected string Name;
        protected int Code;
        protected string Category;
        protected string Size;

        public File(string name, int code, string category, string size)
        {
            this.Name = name;
            this.Code = code;
            this.Category = category;
            this.Size = size; 
        }
        //contrsuctors: static (invoked first, initializes static members), default (initializes fields, properties), parameterized  
        //static and default are always present but not always explicitly declared
    }
    //comment
    //testcomment
    //one more test comment
}
