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
    public class Spell
    {
        public string name { get; set; }
        public string description { get; set; }
        public string higherLevel { get; set; }
        public int range { get; set; }
        public List<char> components { get; set; }
        public string material { get; set; }
        public bool ritual { get; set; }
        public string duration { get; set; }
        public bool concentration { get; set; }
        public string castingTime { get; set; }
        public byte level { get; set; }
    }
}