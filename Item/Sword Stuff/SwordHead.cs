using Sytem;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using Xna.Frameworks.Graphics;
using TAPI;

namespace TAPI.Tools
{
    public class CustomSwordInit
    {
        public CustomSwordInit(ModBase mb)
        {
            mb = this.ModBase();
        }

        public void SetHeadType(string value, int setter)
        {
            switch (value)
            {
                case "Tools:Wood Sword Head": // 1 (normal wood blade)
                    SwordType = 1;
                    break;
                case "Tools:Stone Sword Head": // 2 (begin normalmode heads)                            
                    SwordType = 2;
                    break;
                case "Tools:Copper Sword Head": // 3                            
                    SwordType = 3;
                    break;
                case "Tools:Tin Sword Head": // 4                            
                    SwordType = 4;
                    break;
                case "Tools:Iron Sword Head": // 5                            
                    SwordType = 5;
                    break;
                case "Tools:Lead Sword Head": // 6                            
                    SwordType = 6;
                    break;
                case "Tools:Silver Sword Head": // 7                            
                    SwordType = 7;
                    break;
                case "Tools:Tungsten Sword Head": // 8                            
                    SwordType = 8;
                    break;
                case "Tools:Gold Sword Head": // 9                            
                    SwordType = 9;
                    break;
                case "Tools:Platinum Sword Head": // 10 (end normalmode ore heads)                            
                    SwordType = 10;
                    break;
                case "Tools:Light's Bane Head": // 11 (begin elemental blade heads)                            
                    SwordType = 11;
                    break;
                case "Tools:Blood Butcherer Head": // 12                            
                    SwordType = 12;
                    break;
                case "Tools:Blade of Grass Head": // 13                            
                    SwordType = 13;
                    break;
                case "Tools:Muramasa Head": // 14                            
                    SwordType = 14;
                    break;
                case "Tools:Fiery Blade Head": // 15                            
                    SwordType = 15;
                    break;
                case "Tools:Night's Edge Head": // 16 (end elemental blade heads)                            
                    SwordType = 16;
                    break;
                case "Tools:Breaker Blade Head": // 17 (WoF blade head)                            
                    SwordType = 17;
                    break;
                case "Tools:Candy Cane Sword Head": // 18 (seasonal event heads)                            
                    SwordType = 18;
                    break;
                case "Tools:Haunted Sword Head": // 19                            
                    SwordType = 19;
                    break;
                case "Tools:Horseman's Sword Head": // 20                            
                    SwordType = 20;
                    break;
                case "Tools:Christmas Tree Sword Head": // 21 (end seasonal event heads)                            
                    SwordType = 21;
                    break;
                case "Tools:Shadewood Sword Head": // 22 (other wood heads from here)                            
                    SwordType = 22;
                    break;
                case "Tools:Rich Mahogany Wood Sword Head": // 23                            
                    SwordType = 23;
                    break;
                case "Tools:Pearlwood Sword Head": // 24
                    SwordType = 24;
                    break;
                case "Tools:Cactus Sword Head": // 25 (putting it in the other wood heads part and end of)                            
                    SwordType = 25;
                    break;
                case "Tools:Ice Blade Head": // 26 (begin special / not obtainable by normal crafting normalmode swords)                            
                    SwordType = 26;
                    break;
                case "Tools:Bone Sword Head": // 27                            
                    SwordType = 27;
                    break;
                case "Tools:Enchanted Sword Head": // 28                            
                    SwordType = 28;
                    break;
                case "Tools:Katana Head": // 29                            
                    SwordType = 29;
                    break;
                case "Tools:Starfury Head": // 30                            
                    SwordType = 30;
                    break;
                case "Tools:Bee Keeper Head": // 31                            
                    SwordType = 31;
                    break;
                case "Tools:Blue Phaseblade Head": // Counting the phaseblade heads as one and a different category                            
                    SwordType = 32;
                    break;
                case "Tools:Red Phaseblade Head":
                    SwordType = 33;
                    break;
                case "Tools:Purple Phaseblade Head":
                    SwordType = 34;
                    break;
                case "Tools:White Phaseblade Head":
                    SwordType = 35;
                    break;
                case "Tools:Yellow Phaseblade Head":
                    SwordType = 36;
                    break;
                case "Tools:Green Phaseblade Head": // 32 (end of the uncraftable / hard to craft heads)                            
                    SwordType = 37;
                    break;
                case "Tools:Cobalt Sword Head": // 33                            
                    SwordType = 38;
                    break;
                case "Tools:Palladium Sword Head": // 34                            
                    SwordType = 39;
                    break;
                case "Tools:Mythril Sword Head": // 35                            
                    SwordType = 40;
                    break;
                case "Tools:Orichalcum Sword Head": // 36                            
                    SwordType = 41;
                    break;
                case "Tools:Adamantite Sword Head": // 37                            
                    SwordType = 42;
                    break;
                case "Tools:Titanium Sword Head": // 38                            
                    SwordType = 43;
                    break;
                case "Tools:Excalibur Head": // 39 (end of the hardmode ore heads)                            
                    SwordType = 44;
                    break;
                case "Tools:Cutlass Head": // 40 (begin of the uncraftable / hard to craft hardmode heads)                            
                    SwordType = 45;
                    break;
                case "Tools:Frostbrand Head": // 41                            
                    SwordType = 46;
                    break;
                case "Tools:Keybrand Head": // 42                            
                    SwordType = 47;
                    break;
                case "Tools:Beam Sword Head": // 43                             
                    SwordType = 48;
                    break;
                case "Tools:Blue Phasesaber Head": // Counting the phasesaber heads as one and a different category                            
                    SwordType = 49;
                    break;
                case "Tools:Red Phasesaber Head":
                    SwordType = 50;
                    break;
                case "Tools:Purple Phasesaber Head":
                    SwordType = 51;
                    break;
                case "Tools:White Phasesaber Head":
                    SwordType = 52;
                    break;
                case "Tools:Yellow Phasesaber Head":
                    SwordType = 53;
                    break;
                case "Tools:Green Phasesaber Head": // 44                            
                    SwordType = 54;
                    break;
                case "Tools:Chlorophyte Claymore Head": // 45 (begin of Chlorophyte heads)                            
                    SwordType = 55;
                    break;
                case "Tools:Chlorophyte Saber Head": // 46 (end of Chlorophyte heads)                            
                    SwordType = 56;
                    break;
                case "Tools:True Night's Edge Head": // 47 --BEGIN OF THE END--                            
                    SwordType = 57;
                    break;
                case "Tools:True Excalibur Head": // 48                            
                    SwordType = 58;
                    break;
                case "Tools:Terra Blade Head": // 49 --END of ALL--                            
                    SwordType = 59;
                    break;
            }
            setter = SwordType;
        }
    }
}