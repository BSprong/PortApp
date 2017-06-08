using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavenParadisio
{
    class Schip
    {
        // Fields
        private string naam;
        private int lengte;
        private string lading;

        // Properties
        public string Naam { get { return naam; } }
        public int Lengte { get { return lengte; } }
        public string Lading { get; }

        public bool HeeftGevaarlijkeLading
        {
            get
            {
                if(Lading == "lpg")
                {
                    return true;
                }
                else if(Lading == "LPG") { return true; }
                else if(Lading == "stookolie") { return true; }
                else if (Lading == "Stookolie") { return true; }
                else { return false; }
            }
            set
            {
                
            }
        }

       


        // Constructors
        public Schip(string naam, int lengte)
        {
            this.naam = naam;
            this.lengte = lengte;
            Lading = "onbekend";
        }


        public Schip(string naam, int lengte, string lading)
        {
            this.naam = naam;
            this.lengte = lengte;
            this.Lading = lading;

        }

        // Methods
        public string GeefInformatie(string naam, int lengte, string lading)
        {
            return naam + lengte + lading;
        }

      

    }
}
