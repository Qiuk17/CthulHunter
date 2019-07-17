using System;
using System.Collections.Generic;
using System.Text;

namespace CthulHunter
{
    abstract class ChEvent : ChObject
    {
    }

    class AttackEvent : ChEvent
    {
        public IAttackable From { get; }
        public IAttackTarget To { get; }
        public int Damage { get; }
        public AttackEvent(IAttackable from, IAttackTarget to, int damage)
        {
            From = from; To = to; Damage = damage;
        }
    }
}
