using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ytest
{
    class Film
    {
        protected string Director;
        protected string LeadingActor;
        protected string MainActress;
        public Film(string name, int code, string category, string size, string director, string leadingActor, string mainActress) : base(name, code, category, size)
        {
            this.Director = director;
            this.LeadingActor = leadingActor;
            this.MainActress = mainActress;
        }
        public void Play()
        { }
        public void RetrieveInformation()
        { }
    }
}
