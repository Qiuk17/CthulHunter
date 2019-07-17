using System;
using System.Collections.Generic;
using System.Text;

namespace CthulHunter
{
    /// <summary>
    /// 所有技能的接口
    /// </summary>
    interface ISkill
    {
        string Name { get; set; }
        string Description { get; set; }
    }
    
    /// <summary>
    /// 可拥有技能的实体的接口
    /// </summary>
    interface ISkillful
    {
        List<ISkill> Skills { get; }
    }

    /// <summary>
    /// 可被装备的物品的接口
    /// </summary>
    interface IEquipable
    {
        
    }

    /// <summary>
    /// 可以装备其他物品的实体接口
    /// </summary>
    interface ICanEquip
    {

    }

    /// <summary>
    /// 可以做出攻击行为的实体
    /// </summary>
    interface IAttackable
    {
        void OnAttack(AttackEvent attackEvent);
    }

    /// <summary>
    /// 可被攻击的实体
    /// </summary>
    interface IAttackTarget
    {
        void OnGetAttacked(AttackEvent attackEvent);
    }
}
