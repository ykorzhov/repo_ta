using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ytest
{
    class Program
    {
        static void Main(string[] args)
        {
            Film movie1 = new Film("Spider-man", 21, "Superhero movies", "15GB", "Sam Reime", "Tobey Maguire", "Kirsten Dunst");
            Film movie2 = new Film("Spider-Man: No Way Home", 22, "Superhero movies", "15GB", "Jon Watts", "Tom Holland", "Zendaya");
            Film movie3 = new Film("The Amazing Spider-Man", 23, "Superhero movies", "15GB", "Marc Webb", "Andrew Garfield", "Emma Stone");

            Film[] filmArray = new Film[] { movie1, movie2, movie3 };

            List<File> selectedItems = new List<File>();

            Console.WriteLine();
        }

    }
}
