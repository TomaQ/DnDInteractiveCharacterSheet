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
    //what needs to be in a personal character instance?
    public class PersonalCharacter
    {
        private const string str = "STRENGTH";
        private const string dex = "DEXTERITY";
        private const string con = "CONSTITUTION";
        private const string inte = "INTELLIGENCE";
        private const string wis = "WISDOM";
        private const string cha = "CHARISMA";

        public string characterName { get; set; }
        public List<CharacterJob> characterJobs { get; set; }
        public byte level { get; set; }
        public string background { get; set; }
        public string playerName { get; set; }
        public Race race { get; set; }
        public string alignment { get; set; }
        public int experiencePoints { get; set; }
        Dictionary<string, byte> abilityScores { get; set; }
        Dictionary<string, byte> savingThrows { get; set; }
        Dictionary<string, byte> skills { get; set; }
        public byte perception { get; set; }
        public List<string> languages { get; set; }
        public byte armorClass { get; set; }
        public byte initiative { get; set; }
        public byte speed { get; set; }
        public byte currentHP { get; set; }
        public byte temporaryHP { get; set; }
        public byte hitDice { get; set; }
        public List<Weapon> weapons { get; set; }
        public List<Equipment> equipment { get; set; }
        public string personalityTraits { get; set; }
        public string ideals { get; set; }
        public string bonds { get; set; }
        public string flaws { get; set; }
        public string featuresAndTraits { get; set; }
        public List<Spell> spells { get; set; }

    }
}