using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal class Mamifero : Animal
    {
        public string Amamentar() => "\nAmamenta";
        public override string EmitirSom() => base.EmitirSom() + "ruge*";
    }
}
