﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class PahaKangelane:Kangelase_andmed
    {
        public PahaKangelane(string Nimi, string SuperNimi, string V6ime) : base(Nimi, SuperNimi, V6ime)
        {

        }

        public override void V6iduK6ne()
        { }
    }
}
