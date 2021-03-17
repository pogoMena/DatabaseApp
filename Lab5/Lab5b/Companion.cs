using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
    class Companion
    {
        public string Name { get; set; }
        public string Actor { get; set; }
        public int Doctor { get; set; }
        public string Debut { get; set; }

        public Companion(string name, string actor, int doctor, string debut)
        {
            this.Name = name;
            this.Actor = actor;
            this.Doctor = doctor;
            this.Debut = debut;
        }
    }
}
