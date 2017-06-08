using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavenParadisio
{
    class Haven
    {
        // Fields
        private string naam;
        private List<Schip> schepen;


        // Properties
        public string Naam { get { return naam; } }
        public List<Schip> Schepen { get { return schepen; } }


        // Constructors
        public Haven(string naam)
        {
            this.naam = naam;
            this.schepen = new List<Schip>();
        }


        // Methods
        public bool BoekEenSchipIn(string naam, int lengte, string lading )
        {
            // vervang onderstaande code
            
            foreach (Schip m in schepen)
            {
                if (m.Naam == naam)
                {
                    return false;
                }
                
               

            }
            Schip temp = new Schip(naam, lengte, lading);
            schepen.Add(temp);
            return true;
        }

        public List<Schip> GeefAlleArtikelen()
        {
            return schepen;
        }

        public Schip BoekEenSchipUit(string naam)
        {
            Schip gevondenschip = GeefSchip(naam);
            schepen.Remove(gevondenschip);
            return null;
        }

        public string GeefStatistiek()
        {
            // vervang onderstaande code
            int number = schepen.Count;
            return number.ToString();
            
        }

        public Schip GeefSchip(string naam)
        {
            foreach(Schip s in schepen)
            {
                if(s.Naam == naam)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
