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

        public void GetHandleType(string value, int setter)
        {
            int SwordType;
            switch (value)
            {
                case "Tools:Wood Sword Handle": // 1 (normal wood handle)
                    SwordType = 1;
                    break;
                case "Tools:Stone Sword Handle": // 2 (begin normalmode handles)                            
                    SwordType = 2;
                    break;
                case "Tools:Copper Sword Handle": // 3                            
                    SwordType = 3;
                    break;
                case "Tools:Tin Sword Handle": // 4                            
                    SwordType = 4;
                    break;
                case "Tools:Iron Sword Handle": // 5                            
                    SwordType = 5;
                    break;
                case "Tools:Lead Sword Handle": // 6                            
                    SwordType = 6;
                    break;
                case "Tools:Silver Sword Handle": // 7                            
                    SwordType = 7;
                    break;
                case "Tools:Tungsten Sword Handle": // 8                            
                    SwordType = 8;
                    break;
                case "Tools:Gold Sword Handle": // 9                            
                    SwordType = 9;
                    break;
                case "Tools:Platinum Sword Handle": // 10 (end normalmode ore handles)                            
                    SwordType = 10;
                    break;
                case "Tools:Light's Bane Handle": // 11 (begin elemental blade handles)                            
                    SwordType = 11;
                    break;
                case "Tools:Blood Butcherer Handle": // 12                            
                    SwordType = 12;
                    break;
                case "Tools:Blade of Grass Handle": // 13                            
                    SwordType = 13;
                    break;
                case "Tools:Muramasa Handle": // 14                            
                    SwordType = 14;
                    break;
                case "Tools:Fiery Blade Handle": // 15                            
                    SwordType = 15;
                    break;
                case "Tools:Night's Edge Handle": // 16 (end elemental blade handles)                            
                    SwordType = 16;
                    break;
                case "Tools:Breaker Blade Handle": // 17 (WoF blade Handle)                            
                    SwordType = 17;
                    break;
                case "Tools:Candy Cane Sword Handle": // 18 (seasonal event handles)                            
                    SwordType = 18;
                    break;
                case "Tools:Haunted Sword Handle": // 19                            
                    SwordType = 19;
                    break;
                case "Tools:Horseman's Sword Handle": // 20                            
                    SwordType = 20;
                    break;
                case "Tools:Christmas Tree Sword Handle": // 21 (end seasonal event handles)                            
                    SwordType = 21;
                    break;
                case "Tools:Shadewood Handle": // 22 (other wood handles from here)                            
                    SwordType = 22;
                    break;
                case "Tools:Ebonwood Handle": // 23                            
                    SwordType = 23;
                    break;
                case "Tools:Rich Mahogany Wood Sword Handle": // 24                            
                    SwordType = 24;
                    break;
                case "Tools:Pearlwood Sword Handle": // 25
                    SwordType = 25;
                    break;
                case "Tools:Cactus Sword Handle": // 26 (putting it in the other wood handles part and end of)                            
                    SwordType = 26;
                    break;
                case "Tools:Ice Blade Handle": // 27 (begin special / not obtainable by normal crafting normalmode handles)                            
                    SwordType = 27;
                    break;
                case "Tools:Bone Sword Handle": // 28                            
                    SwordType = 28;
                    break;
                case "Tools:Enchanted Sword Handle": // 29                            
                    SwordType = 29;
                    break;
                case "Tools:Katana Handle": // 30                            
                    SwordType = 30;
                    break;
                case "Tools:Starfury Handle": // 31                            
                    SwordType = 31;
                    break;
                case "Tools:Bee Keeper Handle": // 32                            
                    SwordType = 32;
                    break;
                case "Tools:Blue Phaseblade Handle": // Counting the phaseblade handles as one and a different category                            
                    SwordType = 33;
                    break;
                case "Tools:Red Phaseblade Handle":
                    SwordType = 34;
                    break;
                case "Tools:Purple Phaseblade Handle":
                    SwordType = 35;
                    break;
                case "Tools:White Phaseblade Handle":
                    SwordType = 36;
                    break;
                case "Tools:Yellow Phaseblade Handle":
                    SwordType = 37;
                    break;
                case "Tools:Green Phaseblade Handle": // 33 (end of the uncraftable / hard to craft handles)                            
                    SwordType = 38;
                    break;
                case "Tools:Cobalt Sword Handle": // 34                            
                    SwordType = 39;
                    break;
                case "Tools:Palladium Sword Handle": // 35                            
                    SwordType = 40;
                    break;
                case "Tools:Mythril Sword Handle": // 36                          
                    SwordType = 41;
                    break;
                case "Tools:Orichalcum Sword Handle": // 37                            
                    SwordType = 42;
                    break;
                case "Tools:Adamantite Sword Handle": // 38                            
                    SwordType = 43;
                    break;
                case "Tools:Titanium Sword Handle": // 39                          
                    SwordType = 44;
                    break;
                case "Tools:Excalibur Handle": // 40 (end of the hardmode ore handles)                            
                    SwordType = 45;
                    break;
                case "Tools:Cutlass Handle": // 41 (begin of the uncraftable / hard to craft hardmode handles)                            
                    SwordType = 46;
                    break;
                case "Tools:Frostbrand Handle": // 42                            
                    SwordType = 47;
                    break;
                case "Tools:Keybrand Handle": // 43                            
                    SwordType = 48;
                    break;
                case "Tools:Beam Sword Handle": // 44                             
                    SwordType = 49;
                    break;
                case "Tools:Blue Phasesaber Handle": // Counting the phasesaber handles as one and a different category                            
                    SwordType = 50;
                    break;
                case "Tools:Red Phasesaber Handle":
                    SwordType = 51;
                    break;
                case "Tools:Purple Phasesaber Handle":
                    SwordType = 52;
                    break;
                case "Tools:White Phasesaber Handle":
                    SwordType = 53;
                    break;
                case "Tools:Yellow Phasesaber Handle":
                    SwordType = 54;
                    break;
                case "Tools:Green Phasesaber Handle": // 45                            
                    SwordType = 55;
                    break;
                case "Tools:Chlorophyte Claymore Handle": // 46 (begin of Chlorophyte handles)                            
                    SwordType = 56;
                    break;
                case "Tools:Chlorophyte Saber Handle": // 47 (end of Chlorophyte handles)                            
                    SwordType = 57;
                    break;
                case "vanilla:Broken Hero Sword": // 48 --BEGIN OF THE END--
                    SwordType = 58;
                    break;
                case "Tools:True Night's Edge Handle": // 49                            
                    SwordType = 59;
                    break;
                case "Tools:True Excalibur Handle": // 50                            
                    SwordType = 60;
                    break;
                case "Tools:Terra Blade Handle": // 51 --END of ALL--                            
                    SwordType = 61;
                    break;
            }
            setter = SwordType;
        }
    }
}