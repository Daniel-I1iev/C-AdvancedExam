using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> bees = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> beeEaters = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (bees.Count > 0 && beeEaters.Count > 0)
        {
            int beesGroup = bees[0];
            int beeEatersGroup = beeEaters[beeEaters.Count - 1];

            
            int beesKilled = Math.Min(beeEatersGroup * 7, beesGroup);
            beesGroup -= beesKilled;
            beeEatersGroup -= beesKilled / 7;

            if (beesGroup <= 0)
            {
                
                bees.RemoveAt(0);
            }
            else
            {
                bees[0] = beesGroup;
                
                bees.Add(bees[0]);
                bees.RemoveAt(0);
            }

            if (beeEatersGroup <= 0)
            {
                
                beeEaters.RemoveAt(beeEaters.Count - 1);
            }
            else if (beeEaters.Count > 0)
            {
               
                beeEaters[beeEaters.Count - 1] = beeEatersGroup;
            }
        }

        Console.WriteLine("The final battle is over!");
        if (bees.Count == 0 && beeEaters.Count == 0)
        {
            Console.WriteLine("But no one made it out alive!");
        }
        else if (bees.Count > 0)
        {
            Console.Write("Bee groups left: ");
            for (int i = 0; i < bees.Count; i++)
            {
                Console.Write(bees[i]);
                if (i < bees.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.Write("Bee-eater groups left: ");
            for (int i = 0; i < beeEaters.Count; i++)
            {
                Console.Write(beeEaters[i]);
                if (i < beeEaters.Count - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}
