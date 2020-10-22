using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            /*
            foreach(Flavor item in availableFlavors)
            {
                Console.WriteLine(item.Name);
            }
            */
            //FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(new FlavorComparer());
            availableCones.Sort(new ConeComparer());

            /*
            Console.WriteLine("\n");
            foreach (Flavor item in availableFlavors)
            {
                Console.WriteLine(item.Name);
            }*/

            foreach (Cone item in availableCones)
            {
                Console.WriteLine(item);
            }




            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
