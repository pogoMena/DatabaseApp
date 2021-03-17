using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5b
{
    class Doctor
    {
        public int Position { get; set; }
        public string Actor { get; set; }
        public int Series { get; set; }
        public int Age { get; set; }
        public string Debut { get; private set; }
        public Image Picture { get; private set; }

        public Doctor(int position, string actor, int series, int age, string debut, Image picture)
        {
            this.Position = position;
            this.Actor = actor;
            this.Series = series;
            this.Age = age;
            this.Debut = debut;
            this.Picture = picture;
        }
    }
}
