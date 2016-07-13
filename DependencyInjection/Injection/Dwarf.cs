using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Injection
{
    class Dwarf : IRace
    {
        public string Greet()
        {
            return "I am a Dwarf";
        }
    }
}
