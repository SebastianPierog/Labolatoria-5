using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TPT
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new Laptop() { Price = 1000, Description = "StandardLaptop", Weight = 3 });
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Computers.Add(new Laptop() { Price = 1000, Description = "LightWeight", Weight = 1 });
            tpt.SaveChanges();

            var tpc = new TPCContext();
            tpc.Computers.Add(new Laptop() { Price = 1000, Description = "LightWeight2", Weight = 2 });
            tpc.SaveChanges();

            Console.WriteLine("Ready");


        }
    }
}
