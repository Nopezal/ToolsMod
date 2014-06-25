using Sytem;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using Xna.Frameworks.Graphics;
using TAPI;

namespace TAPI.Tools
{   
    public class MainVar
    {
        int[] typeHandler;
        List<Item> customWeaponSword = new List<Item>();
        List<Item> customWeaponGun = new List<Item>();
        List<Item> customWeaponSpell = new List<Item>();
        //Def lists
        List<Item> swordheads = new List<Item>();
        List<Item> swordhandles = new List<Item>();
        List<Item> modifiers = new List<Item>();
        List<Item> attmodifiers = new List<Item>();
        public MainVar() {  }
    }
}