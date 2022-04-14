using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    public class Music : File
    {
        protected string Singer;
        protected int Length;

        public Music(string name, int code, string category, string size, string singer, int length) : base(name, code, category, size)
        {
            this.Singer = singer;
            this.Length = length;
        }
        public void Play()
        { }
        public void RetrieveInformation()
        { }
        public override string ToString()
        {
            return $"{Name} - {Code} - {Category} - {Size} - {Singer} - {Length}";
        }
    }
}
