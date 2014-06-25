using Sytem;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using Xna.Frameworks.Graphics;
using TAPI;
using TAPI.Tools;

namespace TAPI.Tools
{
    public class AttackModifier //Not really an item, since stuff... (all others declared in the friggin list)
    {
        public AttackModifier(ModBase mb)
        {
            mb = this.ModBase();
        }
        public int SetAttModifierTypes(string value, int setter)
        {
            int SwordType;
            switch (value)
            {
                case "Tools:Sharpening Stone": //1. Occasional drop from stone?
                    SwordType = 1;
                    break;
                case "Tools:Sharper Stone": //2. By sharpening a sharpening stone with another
                    SwordType = 2;
                    break;
                case "Tools:Enchanted Rock": //3. By... Errr... Enchanting a sharper stone?
                    SwordType = 3;
                    break;
                case "Tools:Pointy Arrow": //4. By breaking an arrow
                    SwordType = 4;
                    break;
                case "Tools:Water Ice": //5. Ocassional drop from... Ice?
                    SwordType = 5;
                    break;
                case "Tools:Nail in Wood": //6. Wood + Iron/Lead?
                    SwordType = 6;
                    break;
                case "Tools:Zombie Skin": //7. To FLESH it out a little (okay, that was a bad pun) Dropped by zombies
                    SwordType = 7;
                    break;
                case "Tools:Heap of Bones": //8. Drop by skeletons (cave?)
                    SwordType = 8;
                    break;
                case "Tools:Fragmented Crystal": //9. Occasional drop by Chaos Elementals?
                    SwordType = 9;
                    break;
                case "vanilla:Topaz": //10.
                    SwordType = 10;
                    break;
                case "vanilla:Amethyst": //11.
                    SwordType = 11;
                    break;
                case "vanilla:Emerald": //12.
                    SwordType = 12;
                    break;
                case "vanilla:Sapphire": //13.
                    SwordType = 13;
                    break;
                case "vanilla:Ruby": //14.
                    SwordType = 14;
                    break;
                case "vanilla:Diamond": //15.
                    SwordType = 15;
                    break;
                case "Tools:Sword Polisher": //16. Bleh... Bought from Tinkerer?
                    SwordType = 16;
                    break;
                case "Tools:Otherworldly Essence": //17. Gotten from meteors
                    SwordType = 17;
                    break;


                /* Some boss attackmods ahead*/
                case "Tools:Gigantic Lens": //18. EoC
                    SwordType = 18;
                    break;
                case "Tools:Eater Spine": //19. EoW
                    SwordType = 19;
                    break;
                case "Tools:Crimera Spine": //20. BoC
                    SwordType = 20;
                    break;
                case "Tools:Skeletron Phalanx": //21. Skeletron
                    SwordType = 21;
                    break;
                case "Tools:Honey Stalagmites": //22. Queen Bee
                    SwordType = 22;
                    break;
                case "Tools:Probium": //23. Destroyer
                    SwordType = 23; 
                    break;
                case "Tools:Cursium": //24. Spaz
                    SwordType = 24;
                    break;
                case "Tools:Holium": //25. Ret
                    SwordType = 25;
                    break;
                case "Tools:Bonium": //26. Skelly Prime
                    SwordType = 26;
                    break;
                case "Tools:Hardened Flora": //27. Plantera
                    SwordType = 27;
                    break;
                case "Tools:Stone of Totems": //28. Golem
                    SwordType = 27;
                    break;
            }
            setter = SwordType;
        }
    }
}