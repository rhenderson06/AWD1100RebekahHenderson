using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectLibrary
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public string Img { get; set; }

        //public List<Review> Reviews { get; set; }

        public Book() { }

        public string GetDisplayText() => $"{Isbn}\t   {Title}\t{Author}\t{ReleaseYear}";
    }
}
