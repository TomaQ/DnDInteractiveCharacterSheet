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

            //check for read and write permissions
            Utility.CheckPermissions(this);

            //check for existing characters
            
        }
    }
}

