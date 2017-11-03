using Android.App;
using Android.Widget;
using Android.OS;
using DnDCharSheet.Classes;
using System.IO;
using System;

namespace DnDCharSheet
{
    [Activity(Label = "DnD Interactive Character Sheet", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.Main);

            Utility.CheckPermissions(this);
            try
            {
                string databasePath = Path.Combine(Utility.STORAGE_PATH, "db.db");
                var db = new SQLite.SQLiteConnection(databasePath);
                db.CreateTable<PersonalCharacter>();
                System.Diagnostics.Debug.WriteLine("=======Wrote to: " + databasePath);
            }
            catch(Exception ex)
            {
                Utility.Log(ex);
            }
        }
    }
}

