using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    public class App : File
    {
        public App(string name, int code, string category, string size) : base(name, code, category, size)
        {
        }
        public override string ToString()
        {
            return $"{Name} - {Code} - {Category} - {Size}";
        }
    }
}
