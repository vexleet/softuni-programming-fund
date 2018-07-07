using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite_04
{
    class Dwarf
    {
        public string DwarfName;
        public Hat DwarfHatColor;
        public int DwarfPhysics;
    }

    class Hat
    {
        public string Name;
        public long Count;

        public Hat(string name)
        {
            this.Name = name;
            this.Count = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            HashSet<Hat> hats = new HashSet<Hat>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] splitInput = input.Split(new char[] { '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string dwarfName = splitInput[0].TrimEnd();
                string dwarfHatColor = splitInput[1].TrimStart().TrimEnd();
                int dwarfPhysics = int.Parse(splitInput[2]);

                if (dwarfs.Any(x => x.DwarfName == dwarfName))
                {
                    if (dwarfs.Any(x => x.DwarfName == dwarfName && x.DwarfHatColor.Name == dwarfHatColor))
                    {
                        Dwarf existingDwarf = dwarfs.First(x => x.DwarfName == dwarfName && x.DwarfHatColor.Name == dwarfHatColor);

                        if (dwarfPhysics > existingDwarf.DwarfPhysics)
                        {
                            existingDwarf.DwarfPhysics = dwarfPhysics;
                        }
                        input = Console.ReadLine();
                        continue;
                    }

                    Dwarf createNewDwarf = new Dwarf();
                    createNewDwarf.DwarfName = dwarfName;
                    if (hats.Select(x => x.Name).Contains(dwarfHatColor))
                    {
                        hats.Single(x => x.Name == dwarfHatColor).Count++;
                    }
                    else
                    {
                        hats.Add(new Hat(dwarfHatColor));
                    }
                    createNewDwarf.DwarfHatColor = hats.Single(x => x.Name == dwarfHatColor);
                    createNewDwarf.DwarfPhysics = dwarfPhysics;

                    dwarfs.Add(createNewDwarf);
                }
                else
                {
                    Dwarf createNewDwarf = new Dwarf();
                    createNewDwarf.DwarfName = dwarfName;
                    if (hats.Select(x => x.Name).Contains(dwarfHatColor))
                    {
                        hats.Single(x => x.Name == dwarfHatColor).Count++;
                    }
                    else
                    {
                        hats.Add(new Hat(dwarfHatColor));
                    }
                    createNewDwarf.DwarfHatColor = hats.Single(x => x.Name == dwarfHatColor);
                    createNewDwarf.DwarfPhysics = dwarfPhysics;

                    dwarfs.Add(createNewDwarf);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dwarfs.OrderByDescending(x => x.DwarfPhysics).ThenByDescending(x => x.DwarfHatColor.Count))
            {
                Console.WriteLine($"({item.DwarfHatColor.Name}) {item.DwarfName} <-> {item.DwarfPhysics}");
            }
        }
    }
}
