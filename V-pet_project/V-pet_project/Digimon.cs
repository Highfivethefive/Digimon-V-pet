using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_pet_project
{
    internal class Digimon
    {
        string digimonName = "";
        string yourname = "";
        int Age = 0;
        int CareMistakes = 0;
        int Hunger = 0;
        int Strength = 0;
        int effort = 0;
        int Dp =0;
        int powergroup = 0;
        int weight = 0;
        int winrecord = 0;

        //not sure
        int training = 0;
        int flush = 0;
        int medical = 0;
        int light =0;

        //legacy values
        int Album = 0;

        enum Stage
        {
            child,baby,Adult,Egg;
        }


        public Digimon(string name) { }
        public Digimon()
        { 
        }
    }
}
