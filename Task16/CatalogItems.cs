using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    public class CatalogItems
    {
        Music song1 = new Music("2 + 2 = 5", 1, "Pop", "10MB", "Radiohead", 180);
        Music song2 = new Music("BlahBlah", 2, "Pop", "5MB", "BlahBlah", 180);
        Music song3 = new Music("BlahBlah", 3, "Pop", "5MB", "BlahBlah", 180);

        Film movie1 = new Film("Spider-man", 11, "Superhero movies", "15GB", "Sam Reime", "Tobey Maguire", "Kirsten Dunst");
        Film movie2 = new Film("Spider-Man: No Way Home", 12, "Superhero movies", "15GB", "Jon Watts", "Tom Holland", "Zendaya");
        Film movie3 = new Film("The Amazing Spider-Man", 13, "Superhero movies", "15GB", "Marc Webb", "Andrew Garfield", "Emma Stone");

        App app1 = new App("VisualStudio", 21, "desktop app", "10GB");
        App app2 = new App("Twitter", 22, "mobile", "300MB");
        App app3 = new App("Postman", 23, "desktop app", "1GB");

        public Music[] musicArray;
        public Film[] filmArray;
        public App[] appsArray;


        public CatalogItems()
        {
            musicArray = new Music[] { song1, song2, song3 };
            filmArray = new Film[] { movie1, movie2, movie3 };
            appsArray = new App[] { app1, app2, app3 };
        }


        public virtual void ShowMusicFiles()
        {
            foreach (var musicFile in musicArray)
                Console.WriteLine(musicFile.ToString());
        }
        public void ShowFilms()
        {
            foreach (var filmFile in filmArray)
                Console.WriteLine(filmFile.ToString());
        }
        public void ShowApps()
        {
            foreach (var appFile in appsArray)
                Console.WriteLine(appFile.ToString());
        }
        
    }
}
