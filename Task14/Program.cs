using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            //task14
            var photoBook1 = new PhotoBook();
            Console.WriteLine($"Pages in this photobook: {photoBook1.GetNumberPages()}");

            var photoBook2 = new PhotoBook(24);
            Console.WriteLine($"Pages in this photobook: {photoBook2.GetNumberPages()}");

            var photoBook3 = new BigPhotoBook();
            Console.WriteLine($"Pages in this photobook: {photoBook3.GetNumberPages()}");
            Console.ReadKey();
        }
    }
}
