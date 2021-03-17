using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Episode
    {
        public string Story { get; set; }
        public int Season { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public Episode(string story, int season, int year, string title)
        {
            this.Story = story;
            this.Season = season;
            this.Year = year;
            this.Title = title;
        }
    }
}
