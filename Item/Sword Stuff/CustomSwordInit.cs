using Sytem;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using Xna.Frameworks.Graphics;
using TAPI;
using TAPI.Tools;
using PoroCYon.MCT.UI;
using PoroCYon.MCT.UI.Interface;
using PoroCYon.MCT.UI.Interface.Controls;
using PoroCYon.MCT.UI.Interface.Controls.Primitives;

namespace TAPI.Tools
{
    /*
        Log 1: Holy cr*p... This took ages! I just finished writing down all of the heads... In total, there are over 50 different kind of heads...
     *      In my next log though, I'm gonna have a lot of other progress done.
     *      (getting all of the handle types set up, since it really is copy-pasting,
     *      but for a few things (like changing the stats and name + adding a vanilla handle) thing.)
        Log 2: I decided to move this log to somewhere else. I lied about my next log... So... REPLACING GO! Much better! My next log'll have more progress, though.
     *      Just found out in total I have 59 heads... And now to make instances of them ;_; YUS I MAY SLEEP NOW! (ugh, my brain...)
        Log 3: Poro just cleaned up mah code. Before he cleaned it, it 1. Was a total mess; 2. Had a buncha syntax errors.
     *      Just finished A WHOLE LOTTA progress. And I have to sleep. I finished the handles and some modifiers and converted some parameters to an int array.
        Log 4: Poro thought it was a good idea to move some stuff from this class... I'll make this class the initializer for the swords.
     *      I'll also make a class for the variables. (Gee oh gee, I wonder if Poro will be accepted as a member of the Tools team)
        Log 5: Long time no see, source code of the initializer. Oof, damnit... That took long. I added a bunch of pathnames.
        Log 6: I made some progress inbetween, but forgot that. Right now I was making some more attackmods. I shall work further on my construction of swords.
     *      Just made up my mind about something: Original ores will have less damage, but higher multiplier and the alt ones switched.
     */

    public abstract class CustomSwordInit : ModItem
    {
        public CustomSwordInit(ModBase mb, Item I)
            : base(mb, I)
        {

        }
        public SpriteBatch DrawSword(int swordhead, int swordhandle, int modifier, int attmodifier) //because I SHALL NOT DRAW without a sb method
        {
            SpriteBatch sb = new SpriteBatch();
            switch (swordhead)
            {
                case 1:
                    sb.Draw(ModBaseInstance.textures["Item/Combo Sprites/Wood Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 2:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Stone Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 3:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Copper Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 4:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Tin Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 5:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Iron Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 6:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Lead Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 7:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Silver Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 8:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Tungsten Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 9:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Gold Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 10:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Platinum Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 11:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Light's Bane Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 12:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Blood Butcherer Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 13:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Blade of Grass Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 14:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Muramasa Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 15:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Fiery Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 16:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Night's Edge Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 17:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Breaker Blade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 18:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Candy Cane Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 19:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Haunted Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 20:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/The Horseman's Blade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 21:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Christmas Tree Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 22:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Shadewood Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 23:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Ebonwood Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 24:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Rich Mahogany Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 25:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Pearlwood Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 26:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Cactus Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 27:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Ice Blade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 28:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Bone Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 29:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Enchanted Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 30:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Katana Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 31:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Starfury Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 32:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Bee Keeper Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 33:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Blue Phaseblade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 34:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Red Phaseblade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 35:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Purple Phaseblade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 36:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/White Phaseblade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 37:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Yellow Phaseblade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 38:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Green Phaseblade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 39:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Cobalt Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 39:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Palladium Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 41:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Mythril Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 42:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Orichalcum Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 43:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Adamantite Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 44:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Titanium Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 45:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Excalibur Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 46:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Cutlass Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 47:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Frostbrand Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 48:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Keybrand Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 49:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Beam Sword Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 50:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Blue Phasesaber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 51:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Red Phasesaber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 52:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Purple Phasesaber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 53:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/White Phasesaber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 54:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Yellow Phasesaber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 55:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Green Phasesaber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 56:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Chlorophyte Claymore Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 57:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Chlorophyte Saber Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 58:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/True Night's Edge Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 59:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/True Excalibur Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
                case 60:
                    sb.Draw(modbaseInstance.textures["Item/Combo Sprites/Terra Blade Head.png"], I.size[128, 128], I.GetTextureColor);
                    break;
            }
        }
        public virtual void ConstructSword(Item custom, int swordhead, int swordhandle, int modifier, int attmodifier)
        {
        #region Tons of Vars
            MainVar mv = new MainVar();
            swordhead = mv.typeHandler[0];
            swordhandle = mv.typeHandler[1];
            modifier = mv.typeHandler[2];
            attmodifier = mv.typeHandler[3];
            custom.crit = 0.03f;
            SwordHead.GetHeadType(); //REMINDER: for checking the value of the swordheads/handles/etc.
            SwordHandle.GetHandleType();
            Modifier.GetModifierType();
            SpriteBatch sb = new SpriteBatch();
            int damage1;
            int damage2;
            int damage3;
            int deltaDamage;
        #endregion
            //Sorry for the gigaswitch, I have no idea if you can handle it in another way :c
            switch (swordhead)
            {
                case 1:
                    damage1 = 6;
                    break;
                case 2:
                    damage1 = 7;
                    break;
                case 3:
                    damage1 = 8;
                    break;
                case 4:
                    damage1 = 8;
                    break;
                case 5:
                    damage1 = 10;
                    break;
                case 6:
                    damage1 = 11;
                    break;
                case 7:
                    damage1 = 11;
                    break;
                case 8:
                    damage1 = 12;
                    break;
                case 9:
                    damage1 = 13;
                    break;
                case 10:
                    damage1 = 15;
                    break;
                case 11:
                    damage1 = 17;
                    break;
                case 12:
                    damage1 = 23;
                    break;
                case 13:
                    damage1 = 28;
                    break;
                case 14:
                    damage1 = 18;
                    break;
                case 15:
                    damage1 = 36;
                    break;
                case 16:
                    damage1 = 42;
                    break;
                case 17:
                    damage1 = 39;
                    break;
                case 18:
                    damage1 = 16;
                    break;
                case 19:
                    damage1 = 24;
                    break;
                case 20:
                    damage1 = 73;
                    break;
                case 21:
                    damage1 = 75;
                    break;
                case 22:
                    damage1 = 10;
                    break;
                case 23:
                    damage1 = 10;
                    break;
                case 24:
                    damage1 = 8;
                    break;
                case 25:
                    damage1 = 11;
                    break;
                case 26:
                    damage1 = 9;
                    break;
                case 27:
                    damage1 = 13;
                    break;
                case 28:
                    damage1 = 7;
                    break;
                case 29:
                    damage1 = 7;
                    break;
                case 30:
                    damage1 = 7;
                    break;
                case 31:
                    damage1 = 7;
                    break;
                case 32:
                    damage1 = 7;
                    break;
                case 33:
                    damage1 = 7;
                    break;
                case 34:
                    damage1 = 7;
                    break;
                case 35:
                    damage1 = 7;
                    break;
                case 36:
                    damage1 = 7;
                    break;
                case 37:
                    damage1 = 7;
                    break;
                case 38:
                    damage1 = 7;
                    break;
                case 39:
                    damage1 = 7;
                    break;
                case 39:
                    damage1 = 7;
                    break;
                case 41:
                    damage1 = 7;
                    break;
                case 42:
                    damage1 = 7;
                    break;
                case 43:
                    damage1 = 7;
                    break;
                case 44:
                    damage1 = 7;
                    break;
                case 45:
                    damage1 = 7;
                    break;
                case 46:
                    damage1 = 7;
                    break;
                case 47:
                    damage1 = 7;
                    break;
                case 48:
                    damage1 = 7;
                    break;
                case 49:
                    damage1 = 7;
                    break;
                case 50:
                    damage1 = 7;
                    break;
                case 51:
                    damage1 = 7;
                    break;
                case 52:
                    damage1 = 7;
                    break;
                case 53:
                    damage1 = 7;
                    break;
                case 54:
                    damage1 = 7;
                    break;
                case 55:
                    damage1 = 7;
                    break;
                case 56:
                    damage1 = 7;
                    break;
                case 57:
                    damage1 = 7;
                    break;
                case 58:
                    damage1 = 7;
                    break;
                case 59:
                    damage1 = 7;
                    break;
                case 60:
                    damage1 = 7;
                    break;
            }
        }
    }
}
