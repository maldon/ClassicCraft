﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicCraft
{
    class Mage : Player
    {
        public Mage(Player p)
            : base(p)
        {
        }

        public Mage(Simulation s, Player p)
            : base(s, p)
        {
        }

        public Mage(Simulation s = null, Races r = Races.Orc, int level = 60, Dictionary<Slot, Item> items = null, Dictionary<string, int> talents = null, List<Enchantment> buffs = null)
            : base(s, Classes.Mage, r, level, items, talents, buffs)
        {
        }

        public override void Rota()
        {
            throw new NotImplementedException();
        }

        public override void SetupTalents(string ptal)
        {
            throw new NotImplementedException();
        }
    }
}
