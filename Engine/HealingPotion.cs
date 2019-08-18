using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int HealAmount { get; set; }

        public HealingPotion(int id, string name, string namePlural, int healAmount) : base(id, name, namePlural)
        {
            HealAmount = healAmount;
        }
    }
}
