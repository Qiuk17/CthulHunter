using System;
namespace CthulHunter
{
    public class ChCreature : ChObject
    {
        public int STR { get; set; }
        public int CON { get; set; }
        public int SIZ { get; set; }
        public int DEX { get; set; }
        public int APP { get; set; }
        public int INT { get; set; }
        public int POW { get; set; }
        public int EDU { get; set; }
        public int LUK { get; set; }

        public bool IsDead { get; set; }
        public ChCreature()
        {
            IsDead = false;
        }
    }
}
