using DependencyInjection.NoInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.NoInjection
{
    public class Community
    {
        public string GreetDwarf()
        {
            return new Dwarf().Greet();
        }

        public string GreetElf()
        {
            return new Elf().Greet();
        }

        public string GreetHuma()
        {
            return new Human().Greet();
        }
    }
}
