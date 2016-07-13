using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Injection
{
    class Human : IRace
    {
        public string Greet()
        {
            return "I am an Human";
        }
    }
}
