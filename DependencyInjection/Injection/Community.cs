using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Injection
{
    public class Community
    {
        protected IRace race;

        public Community(IRace _race)
        {
            this.race = _race;
        }

        public string Greet()
        {
            return this.race.Greet();
        }
    }
}
