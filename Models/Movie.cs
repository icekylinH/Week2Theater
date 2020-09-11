using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theater.Models
{
    public enum Language
    {
        English, Japanese, Chinese
    }
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string ContactEmailAddress { get; set; }

        public Category Categories { get; set; }
        public int CategoryID { get; set; }


    }
}
