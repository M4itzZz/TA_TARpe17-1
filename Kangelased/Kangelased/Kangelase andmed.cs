using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    abstract class Kangelase_andmed:ISuperV6ime
    {
        public string _Nimi;
        public string _superNimi;
        public string _v6ime;

        public Kangelase_andmed(string Nimi, string superNimi, string v6ime)
        {
            _Nimi = Nimi;
            _superNimi = superNimi;
            _v6ime = v6ime;
        }

        public string Nimi { get => _Nimi; set => _Nimi = value; }
        public string SuperNimi { get => _superNimi; set => _superNimi = value; }
        public string V6ime { get => _v6ime; set => _v6ime = value; }

        public string AnnaNimi()
        {
            return Nimi;
        }
        public string AnnaSuperNimi()
        {
            return SuperNimi;
        }
        public string AnnaV6ime()
        {
            return V6ime;
        }
        public abstract void V6iduK6ne();

        
    }
}
