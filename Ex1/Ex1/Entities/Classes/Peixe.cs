using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal class Peixe : Animal
    {
        public string Nadar() => "\nNada*";
        public override string EmitirSom() => base.EmitirSom() + "Borbolha* glu, glu, glu";
    }
}
