using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectLibrary
{
    public class Review
    {
        public string ReviewText { get; set; }

        public Review(string text) { }

        public virtual string ToString()
        {
            return "";
        }
    }
}
