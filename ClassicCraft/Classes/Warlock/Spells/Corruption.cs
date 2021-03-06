﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicCraft
{
    class Corruption : Spell
    {
        public override string ToString() { return NAME; } public static new string NAME = "Corruption";
        
        public static int BASE_COST = 290;
        public static int CD = 0;
        public static double CAST_TIME = 2;

        public Corruption(Player p)
            : base(p, CD, BASE_COST, true, true, School.Shadow, CAST_TIME - 0.4 * p.GetTalentPoints("IC"))
        {
        }

        public override void DoAction()
        {
            base.DoAction();
            CommonManaSpell();

            ResultType res = Simulation.MagicMitigationBinary(Player.Sim.Boss.MagicResist[School]);

            if(res == ResultType.Hit)
            {
                res = Player.SpellAttackEnemy(Player.Sim.Boss, false, 0.02 * Player.GetTalentPoints("Suppr"));
            }
            
            if(res == ResultType.Hit)
            {
                if (Player.Sim.Boss.Effects.ContainsKey(CorruptionDoT.NAME))
                {
                    Player.Sim.Boss.Effects[CorruptionDoT.NAME].Refresh();
                }
                else
                {
                    new CorruptionDoT(Player, Player.Sim.Boss).StartEffect();
                }
            }
        }
    }
}
