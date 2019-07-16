using System;
namespace CthulHunter
{
    public class ChCharacter:ChCreature
    {
        public string Name { get; set; }
        public int MaxHp { get => (STR + CON) / 10; }
        public int Hp { get; set; }
        public int MOV { get; set; }
        public ChCharacter()
        {
        }
    }
}
