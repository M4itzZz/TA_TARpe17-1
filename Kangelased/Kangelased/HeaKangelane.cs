﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class HeaKangelane:Kangelase_andmed
    {
        public HeaKangelane(string Nimi, string SuperNimi, string V6ime): base(Nimi, SuperNimi, V6ime)
        {

        }

        public override void V6iduK6ne()
        {
            Console.WriteLine("Ärge muretsege ma tulin teile appi!");
        }

        public void KasutaV6imet()
        {
            Console.WriteLine("Hea kangelane " + SuperNimi + " päästab maailma!");
        }
    }
}
