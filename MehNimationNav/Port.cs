using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MehNimationNav;

namespace backendPort
{
    class Port
    {
        private List<Stockage> Stockages;
        public Port(List<Stockage> Stockages)
        {
            this.Stockages = Stockages;
        }
       
        public void dechargement(Navire unNavire)
        {
            foreach (var meh in Stockages)
            {
                if (unNavire.QteFret >= meh.CapaDispo) { unNavire.Decharger(meh.CapaDispo); meh.Stocker(meh.CapaDispo); Console.WriteLine(meh.CapaDispo); }
                else { meh.Stocker(meh.CapaDispo); unNavire.Decharger(unNavire.QteFret); }
            }
        }
    }
}
