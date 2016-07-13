using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NoInjection();
            Injection();
        }

        private static void NoInjection()
        {
            DependencyInjection.NoInjection.Community community = new DependencyInjection.NoInjection.Community();
            Console.WriteLine(community.GreetDwarf());
            Console.WriteLine(community.GreetElf());
            Console.WriteLine(community.GreetHuma());
        }

        private static void Injection()
        {
            DependencyInjection.Injection.Community comunityElf = new DependencyInjection.Injection.Community(new DependencyInjection.Injection.Elf());
            Console.WriteLine(comunityElf.Greet());
            DependencyInjection.Injection.Community comunityDwarf = new DependencyInjection.Injection.Community(new DependencyInjection.Injection.Dwarf());
            Console.WriteLine(comunityDwarf.Greet());
            DependencyInjection.Injection.Community comunityHuman = new DependencyInjection.Injection.Community(new DependencyInjection.Injection.Human());
            Console.WriteLine(comunityHuman.Greet());
            Console.Read();
        }
    }
}

