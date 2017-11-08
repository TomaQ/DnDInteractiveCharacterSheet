using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DnDCharSheet.Classes
{
    public class CharacterJob
    {
        public string name { get; set; }
        public string spellcastingAbility { get; set; }
        public byte spellSaveDC { get; set; }
        public byte spellAttackBonus { get; set; }

    }
}