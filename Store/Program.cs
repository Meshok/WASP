using System;

namespace WASP_PR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("HelloWorld", "FooBar");
            store += new Audio("Arctic Monkeys", "Rancho De La Luna", 6, "AM", "rock");
            store += new Audio("Muse", "Grouse Lodge", 6, "Absolution", "rock");
            store += new Audio("Tame Impala", "Kevin Parker's home studio", 4, "Currents", "disco");
            store += new DVD("David Heyman", "Warner Bros. Pictures", 152, "Harry Potter and the Philosopher's Stone", "fantasy");
            store += new DVD("Aron Warner", "DreamWorks Animation", 90, "Shrek", "adventure");
            store += new DVD("Sean McKittrick", "Universal Pictures", 104, "Get out", "horror");
            Console.WriteLine(store);

            foreach(Disk disk in store.GetAudios())
            {
                Console.WriteLine($"{disk.GetName()} --> {disk.DiskSize}");
                disk.Burn("Unknown", "Unknown", "0");
            }

            foreach (Disk disk in store.GetDvds())
            {
                Console.WriteLine($"{disk.GetName()} --> {disk.DiskSize}");
            }
        }
    }
}
