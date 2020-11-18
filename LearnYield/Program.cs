using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LearnYield
{
    class Program
    {
        static IEnumerable<int> CountToFive()
        {
            // yield return 1;
            // yield return 2;
            // yield return 3;
            // yield return 4;
            // yield return 5; 
            //  yield break;
            // yield return 6;
            // yield return 7;
            // yield return 8;
            // yield return 9;

            for (int i = 1; i < 10; i++)
            {
                if(i > 5) yield break;
                yield return i;
                
            }
        }
        static void Main(string[] args)
        {
            var enumerator = CountToFive().GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        
            Console.WriteLine("---------");

            foreach (var VARIABLE in CountToFive())
            {
                Console.WriteLine(VARIABLE);
            }
            
            Console.WriteLine("---------");
            //Question: how to make this show ?
            GalaxyClass.ShowGalaxies();
         }
    }
    public static class GalaxyClass
    {
        public static void ShowGalaxies()
        {
            var theGalaxies = new Galaxies();
            foreach (Galaxy theGalaxy in theGalaxies.NextGalaxy)
            {
                Debug.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears.ToString());
            }
        }

        public class Galaxies
        {

            public System.Collections.Generic.IEnumerable<Galaxy> NextGalaxy
            {
                get
                {
                    yield return new Galaxy { Name = "Tadpole", MegaLightYears = 400 };
                    yield return new Galaxy { Name = "Pinwheel", MegaLightYears = 25 };
                    yield return new Galaxy { Name = "Milky Way", MegaLightYears = 0 };
                    yield return new Galaxy { Name = "Andromeda", MegaLightYears = 3 };
                }
            }
        }

        public class Galaxy
        {
            public String Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}