using System;

namespace Planner
{
    public class GardenObject
    {
        public GardenObject(int iD, string name)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}