using Sytem;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using Xna.Frameworks.Graphics;
using TAPI;
using TAPI.Tools;

namespace TAPI.Tools
{
    public class Modifier //Is not an item (defined in another list, wich'll be merged with the defs one)
    {
        int SwordType;

        public Modifier(ModBase mb)
        {
            mb = this.ModBase();
        } 
        public void SetModifierType(string value, int setter)
        {
            switch (value)
            {
                case "Tools:Bowl of Fire": //1. On Fire!
                    SwordType = 1;
                    break;
                case "Tools:Mistake": //2. Poison!
                    SwordType = 2;
                    break;
                case "Tools:Brain Freeze": //3. Frostburn!
                    SwordType = 3;
                    break;
                case "Tools:Spider Fang": //4. Venom!
                    SwordType = 4;
                    break;
                case "Tools:Slug Slime": //5. Slow!
                    SwordType = 5;
                    break;
                case "Tools:Boof-Blaffer": //6. Confused!
                    SwordType = 6;
                    break;
                case "Tools:De-Musculer": //7. Weak!
                    SwordType = 7;
                    break;
                case "Tools:Scissor Fragment": //8. (klk reference) Broken Armor!
                    SwordType = 8;
                    break;
                case "Tools:Cursed Bowl of Fire"://9. Cursed Inferno!
                    SwordType = 9;
                    break;
                case "Tools:Chilling Ice"://10. Chilled!
                    SwordType = 10;
                    break;
                case "Tools:Liquid Gold"://11. Ichor!
                    SwordType = 11;
                    break;
                case "Tools:Everything Freeze"://12. Frozen!
                    SwordType = 12;
                    break;
                case "Tools:Huge Sandwich": //13. Suffocation for +- 2 sec (-20 HP)
                    SwordType = 13;
                    break;
                case "Tools:Burning Stick"://14. Burning for +- 3 sec (-30 HP)
                    SwordType = 14;
                    break;
                case "Tools:Friendinator"://15. Friendly! (makes opponent friendly for 2-3 seconds (REALLY long ability recharge time + not usable on anything that is a boss to make it not OP))
                    SwordType = 15;
                    break;
            }
            setter = SwordType;
        }
    }
}