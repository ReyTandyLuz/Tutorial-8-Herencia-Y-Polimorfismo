using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal class Ave : Animal
    {
        public string Voar() => "\nVooa*";
        public override string EmitirSom() => base.EmitirSom() + "Piu piu";
    }
}
